using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortUI
{
    public partial class Form1 : Form
    {
        private WMPLib.WindowsMediaPlayer wmp;
        private int playPause = 0;
        Dictionary<string, string> dicMusicPath;
        
        SerialPort serialPort;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
            wmp = new WMPLib.WindowsMediaPlayer();            
            dicMusicPath = new Dictionary<string, string>();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(tbCOMPort.Text == "" || tbCOMPort.Text.Contains("COM"))
            {
                MessageBox.Show("Please input the value of COM Port");
                return;
            }
            int Rate = 9600;
            if(!Int32.TryParse(tbRate.Text,out Rate))
            {
                MessageBox.Show("Please input correct format bault rate");
                return;
            }

            serialPort = new SerialPort(tbCOMPort.Text.Trim());
            serialPort.BaudRate = Rate ;
            serialPort.Parity = Parity.None;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.RtsEnable = true;
            try
            {
                if(isConnected)
                {
                    serialPort.Close();
                    btnConnect.Text = "Connect";
                    isConnected = false;
                    tbRate.Enabled = true;
                    tbCOMPort.Enabled = true;
                    return;
                }
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    isConnected = true;
                    tbRate.Enabled = false;
                    tbCOMPort.Enabled = false;
                    btnConnect.Text = "Disconnect";
                }
               
            }
            catch(Exception ex)
            {

            }
            finally
            {

            }

            
        }
        delegate void Display(string buffer);

        public int totalLength = 0;
        private void DisplayText(string inComingData)
        {
            tbCommand.Text = "";
            switch(inComingData)
            {
                //Pause/Play
                case "UP":
                    PlayPause();
                    break;
                //Stop
                case "DOWN":
                    Stop();
                    break;
                //Previous
                case "LEFT":
                    Previous();
                    break;
                //Next
                case "RIGHT":
                    Next();
                    break;
                //VolumeUp
                case "FAR":
                    VolumeUp();
                    break;
                //VolumeDown
                case "NEAR":
                    VolumeDown();
                    break;
                default:
                    break;
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {   
            string recived = (sender as SerialPort).ReadLine();
            Display d = new Display(DisplayText);
            this.Invoke(d, recived);
            
        }

        private void lbCommand_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtMusicFolder.Text = fbd.SelectedPath;

                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    string[] unwantedExtensions = { ".mp3"}; // you can extend it  
                    StringCollection col = new StringCollection();
                    foreach (string file in files)
                    {
                        string ext = Path.GetExtension(file);
                        string fileName = Path.GetFileName(file);
                        if (unwantedExtensions.Contains<string>(ext))
                        {                            
                            lbMusicList.Items.Add(fileName);
                            dicMusicPath.Add(fileName, file);
                        }
                    }

                    if(lbMusicList.Items.Count > 0)
                        lbMusicList.SelectedIndex = 0;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timerCheckDuration_Tick(object sender, EventArgs e)
        {
            pbDuration.Value = MediaGetPosition();
            lbTotal.Text = wmp.currentMedia.durationString;
            lbCurrent.Text = wmp.controls.currentPositionString;
            /*if (WMPLib.WMPPlayState.wmppsPlaying == wmp.playState)
            {
                
            }
            else
            {
                //timerCheckDuration.Enabled = false;
                lbCurrent.Text = "00:00";
            }*/
        }

        public int MediaGetPosition()
        {
            int ret = 0;
            if (WMPLib.WMPPlayState.wmppsPlaying != wmp.playState)
            {
                return ret;
            }
            double curPos = wmp.controls.currentPosition;
            double totalLen = wmp.currentMedia.duration;
            ret = (int)((curPos / totalLen) * 100);
            return ret;
        }

        private void pbPlayPause_Click(object sender, EventArgs e)
        {
            PlayPause();
        }

        private void PlayPause()
        {
            if (lbMusicList.Items.Count == 0)
                return;

            playPause = playPause == 0 ? 1 : 0;

            if (playPause == 1)
            {
                pbPlayPause.Image = Image.FromFile("../../Pic/rounded-pause-button.png");

                if (wmp.playState != WMPLib.WMPPlayState.wmppsUndefined && wmp.playState != WMPLib.WMPPlayState.wmppsStopped)
                {
                    wmp.controls.play();
                }
                else
                {
                    wmp.URL = dicMusicPath[lbMusicList.SelectedItem.ToString()];
                    wmp.settings.volume = Convert.ToInt32(lbVolume.Text);
                    wmp.controls.play();
                }

                timerCheckDuration.Enabled = true;
            }
            else
            {
                pbPlayPause.Image = Image.FromFile("../../Pic/play-button.png");
                wmp.controls.pause();
                timerCheckDuration.Enabled = false;
            }
        }

        private void pbNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void Next()
        {
            if (lbMusicList.SelectedIndex == lbMusicList.Items.Count - 1)
                lbMusicList.SelectedIndex = 0;
            else
                lbMusicList.SelectedIndex = lbMusicList.SelectedIndex + 1;

            wmp.URL = dicMusicPath[lbMusicList.SelectedItem.ToString()];
            wmp.settings.volume = Convert.ToInt32(lbVolume.Text);
            wmp.controls.play();
        }

        private void pbPrevious_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void Previous()
        {
            if (lbMusicList.SelectedIndex == 0)
                lbMusicList.SelectedIndex = lbMusicList.Items.Count - 1;
            else
                lbMusicList.SelectedIndex = lbMusicList.SelectedIndex - 1;

            wmp.URL = dicMusicPath[lbMusicList.SelectedItem.ToString()];
            wmp.settings.volume = Convert.ToInt32(lbVolume.Text);
            wmp.controls.play();
        }

        private void pbStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Stop()
        {
            pbDuration.Value = 0;
            playPause = 0;
            wmp.controls.stop();
            pbPlayPause.Image = Image.FromFile("../../Pic/play-button.png");
            lbCurrent.Text = "00:00";
            lbTotal.Text = "00:00";
        }

        private void btnVolumeUp_Click(object sender, EventArgs e)
        {
            VolumeUp();
        }

        private void VolumeUp()
        {
            lbVolume.Text = (Convert.ToInt32(lbVolume.Text) + 10).ToString();

            if (Convert.ToInt32(lbVolume.Text) > 100)
                lbVolume.Text = "100";

            wmp.settings.volume = Convert.ToInt32(lbVolume.Text);
        }

        private void btnVolumeDown_Click(object sender, EventArgs e)
        {
            VolumeDown();
        }

        private void VolumeDown()
        {
            lbVolume.Text = (Convert.ToInt32(lbVolume.Text) - 10).ToString();

            if (Convert.ToInt32(lbVolume.Text) < 0)
                lbVolume.Text = "0";

            wmp.settings.volume = Convert.ToInt32(lbVolume.Text);
        }
        
        private void lbMusicList_DoubleClick(object sender, EventArgs e)
        {
            Stop();
            PlayPause();
        }
    }
}
