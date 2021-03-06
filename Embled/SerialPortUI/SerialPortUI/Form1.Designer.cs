﻿namespace SerialPortUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCom = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbCOMPort = new System.Windows.Forms.TextBox();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.lbCommand = new System.Windows.Forms.Label();
            this.pbStop = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbPlayPause = new System.Windows.Forms.PictureBox();
            this.pbPrevious = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pbDuration = new System.Windows.Forms.ProgressBar();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtMusicFolder = new System.Windows.Forms.TextBox();
            this.lbMusicList = new System.Windows.Forms.ListBox();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.timerCheckDuration = new System.Windows.Forms.Timer(this.components);
            this.lbVolume = new System.Windows.Forms.Label();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCom
            // 
            this.lbCom.AutoSize = true;
            this.lbCom.Location = new System.Drawing.Point(20, 21);
            this.lbCom.Name = "lbCom";
            this.lbCom.Size = new System.Drawing.Size(67, 15);
            this.lbCom.TabIndex = 0;
            this.lbCom.Text = "COM Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(331, 62);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 22);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbCOMPort
            // 
            this.tbCOMPort.Location = new System.Drawing.Point(131, 18);
            this.tbCOMPort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCOMPort.Name = "tbCOMPort";
            this.tbCOMPort.Size = new System.Drawing.Size(181, 25);
            this.tbCOMPort.TabIndex = 2;
            // 
            // pbMusic
            // 
            this.pbMusic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbMusic.Image = ((System.Drawing.Image)(resources.GetObject("pbMusic.Image")));
            this.pbMusic.Location = new System.Drawing.Point(12, 140);
            this.pbMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(744, 411);
            this.pbMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMusic.TabIndex = 3;
            this.pbMusic.TabStop = false;
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(131, 62);
            this.tbRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRate.Name = "tbRate";
            this.tbRate.Size = new System.Drawing.Size(181, 25);
            this.tbRate.TabIndex = 5;
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Location = new System.Drawing.Point(20, 65);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(66, 15);
            this.lbRate.TabIndex = 4;
            this.lbRate.Text = "Bault Rate";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbCommand);
            this.panel1.Controls.Add(this.lbCommand);
            this.panel1.Controls.Add(this.lbCom);
            this.panel1.Controls.Add(this.tbRate);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.lbRate);
            this.panel1.Controls.Add(this.tbCOMPort);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 110);
            this.panel1.TabIndex = 6;
            // 
            // tbCommand
            // 
            this.tbCommand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCommand.Location = new System.Drawing.Point(685, 46);
            this.tbCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ReadOnly = true;
            this.tbCommand.Size = new System.Drawing.Size(215, 25);
            this.tbCommand.TabIndex = 7;
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.ForeColor = System.Drawing.Color.DarkRed;
            this.lbCommand.Location = new System.Drawing.Point(633, 19);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(65, 15);
            this.lbCommand.TabIndex = 6;
            this.lbCommand.Text = "Command";
            this.lbCommand.Click += new System.EventHandler(this.lbCommand_Click);
            // 
            // pbStop
            // 
            this.pbStop.Image = ((System.Drawing.Image)(resources.GetObject("pbStop.Image")));
            this.pbStop.Location = new System.Drawing.Point(284, 616);
            this.pbStop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbStop.Name = "pbStop";
            this.pbStop.Size = new System.Drawing.Size(45, 44);
            this.pbStop.TabIndex = 7;
            this.pbStop.TabStop = false;
            this.pbStop.Click += new System.EventHandler(this.pbStop_Click);
            // 
            // pbNext
            // 
            this.pbNext.ImageLocation = "../../Pic/fast-forward.png";
            this.pbNext.Location = new System.Drawing.Point(559, 616);
            this.pbNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(45, 44);
            this.pbNext.TabIndex = 8;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbPlayPause
            // 
            this.pbPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("pbPlayPause.Image")));
            this.pbPlayPause.Location = new System.Drawing.Point(447, 596);
            this.pbPlayPause.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPlayPause.Name = "pbPlayPause";
            this.pbPlayPause.Size = new System.Drawing.Size(85, 80);
            this.pbPlayPause.TabIndex = 9;
            this.pbPlayPause.TabStop = false;
            this.pbPlayPause.Click += new System.EventHandler(this.pbPlayPause_Click);
            // 
            // pbPrevious
            // 
            this.pbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("pbPrevious.Image")));
            this.pbPrevious.Location = new System.Drawing.Point(371, 616);
            this.pbPrevious.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbPrevious.Name = "pbPrevious";
            this.pbPrevious.Size = new System.Drawing.Size(45, 44);
            this.pbPrevious.TabIndex = 10;
            this.pbPrevious.TabStop = false;
            this.pbPrevious.Click += new System.EventHandler(this.pbPrevious_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(761, 410);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 140);
            this.textBox1.TabIndex = 11;
            // 
            // pbDuration
            // 
            this.pbDuration.Location = new System.Drawing.Point(68, 569);
            this.pbDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDuration.Name = "pbDuration";
            this.pbDuration.Size = new System.Drawing.Size(887, 12);
            this.pbDuration.TabIndex = 12;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(959, 140);
            this.btnSelectFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(72, 29);
            this.btnSelectFolder.TabIndex = 13;
            this.btnSelectFolder.Text = "Browse";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtMusicFolder
            // 
            this.txtMusicFolder.Location = new System.Drawing.Point(761, 140);
            this.txtMusicFolder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMusicFolder.Name = "txtMusicFolder";
            this.txtMusicFolder.Size = new System.Drawing.Size(188, 25);
            this.txtMusicFolder.TabIndex = 14;
            // 
            // lbMusicList
            // 
            this.lbMusicList.FormattingEnabled = true;
            this.lbMusicList.ItemHeight = 15;
            this.lbMusicList.Location = new System.Drawing.Point(761, 176);
            this.lbMusicList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbMusicList.Name = "lbMusicList";
            this.lbMusicList.Size = new System.Drawing.Size(268, 229);
            this.lbMusicList.TabIndex = 15;
            this.lbMusicList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.lbMusicList.DoubleClick += new System.EventHandler(this.lbMusicList_DoubleClick);
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Location = new System.Drawing.Point(12, 565);
            this.lbCurrent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(39, 15);
            this.lbCurrent.TabIndex = 16;
            this.lbCurrent.Text = "00:00";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(977, 565);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(39, 15);
            this.lbTotal.TabIndex = 17;
            this.lbTotal.Text = "00:00";
            // 
            // timerCheckDuration
            // 
            this.timerCheckDuration.Interval = 1000;
            this.timerCheckDuration.Tick += new System.EventHandler(this.timerCheckDuration_Tick);
            // 
            // lbVolume
            // 
            this.lbVolume.AutoSize = true;
            this.lbVolume.Location = new System.Drawing.Point(780, 638);
            this.lbVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVolume.Name = "lbVolume";
            this.lbVolume.Size = new System.Drawing.Size(21, 15);
            this.lbVolume.TabIndex = 18;
            this.lbVolume.Text = "30";
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.Location = new System.Drawing.Point(828, 631);
            this.btnVolumeUp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(100, 29);
            this.btnVolumeUp.TabIndex = 19;
            this.btnVolumeUp.Text = "VolumeUp";
            this.btnVolumeUp.UseVisualStyleBackColor = true;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.Location = new System.Drawing.Point(656, 630);
            this.btnVolumeDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(100, 29);
            this.btnVolumeDown.TabIndex = 20;
            this.btnVolumeDown.Text = "VolumeDown";
            this.btnVolumeDown.UseVisualStyleBackColor = true;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 698);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.lbVolume);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.lbMusicList);
            this.Controls.Add(this.txtMusicFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.pbDuration);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbPrevious);
            this.Controls.Add(this.pbPlayPause);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbStop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMusic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Media System";
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrevious)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCom;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbCOMPort;
        private System.Windows.Forms.PictureBox pbMusic;
        private System.Windows.Forms.TextBox tbRate;
        private System.Windows.Forms.Label lbRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCommand;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.PictureBox pbStop;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbPlayPause;
        private System.Windows.Forms.PictureBox pbPrevious;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar pbDuration;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtMusicFolder;
        private System.Windows.Forms.ListBox lbMusicList;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Timer timerCheckDuration;
        private System.Windows.Forms.Label lbVolume;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnVolumeDown;
    }
}

