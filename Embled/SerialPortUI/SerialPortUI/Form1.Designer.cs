namespace SerialPortUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbCom = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbCOMPort = new System.Windows.Forms.TextBox();
            this.pbMusic = new System.Windows.Forms.PictureBox();
            this.tbRate = new System.Windows.Forms.TextBox();
            this.lbRate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCommand = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.pbPlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).BeginInit();
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
            this.btnConnect.Location = new System.Drawing.Point(330, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbCOMPort
            // 
            this.tbCOMPort.Location = new System.Drawing.Point(130, 18);
            this.tbCOMPort.Name = "tbCOMPort";
            this.tbCOMPort.Size = new System.Drawing.Size(181, 25);
            this.tbCOMPort.TabIndex = 2;
            // 
            // pbMusic
            // 
            this.pbMusic.Image = ((System.Drawing.Image)(resources.GetObject("pbMusic.Image")));
            this.pbMusic.Location = new System.Drawing.Point(12, 140);
            this.pbMusic.Name = "pbMusic";
            this.pbMusic.Size = new System.Drawing.Size(400, 301);
            this.pbMusic.TabIndex = 3;
            this.pbMusic.TabStop = false;
            // 
            // tbRate
            // 
            this.tbRate.Location = new System.Drawing.Point(130, 62);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 110);
            this.panel1.TabIndex = 6;
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
            // tbCommand
            // 
            this.tbCommand.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbCommand.Location = new System.Drawing.Point(685, 46);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.ReadOnly = true;
            this.tbCommand.Size = new System.Drawing.Size(214, 25);
            this.tbCommand.TabIndex = 7;
            // 
            // pbPlay
            // 
            this.pbPlay.Image = ((System.Drawing.Image)(resources.GetObject("pbPlay.Image")));
            this.pbPlay.Location = new System.Drawing.Point(543, 171);
            this.pbPlay.Name = "pbPlay";
            this.pbPlay.Size = new System.Drawing.Size(100, 50);
            this.pbPlay.TabIndex = 7;
            this.pbPlay.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 453);
            this.Controls.Add(this.pbPlay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMusic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbMusic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlay)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.PictureBox pbPlay;
    }
}

