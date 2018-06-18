using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortUI
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        bool isConnected = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            serialPort = new SerialPort("COM5");
            serialPort.BaudRate = 9600;
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
                    return;
                }
                serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    isConnected = true;
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
            switch(inComingData)
            {
                case "UP":
                    break;
                case "DOWN":
                    break;
                case "LEFT":
                    break;
                case "RIGHT":
                    break;
                case "FAR":
                    break;
                case "NEAR":
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
    }
}
