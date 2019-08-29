namespace SBBarcode
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboCam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseCam = new System.Windows.Forms.Button();
            this.btnOpenCam = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.btnCapturePic = new System.Windows.Forms.Button();
            this.btnReadBarcode = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshPort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.btnClosePort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.Black;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(3, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(562, 294);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 10;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // picCapture
            // 
            this.picCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picCapture.Location = new System.Drawing.Point(571, 3);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(562, 294);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 4;
            this.picCapture.TabStop = false;
            // 
            // lstMsg
            // 
            this.lstMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(3, 303);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(562, 172);
            this.lstMsg.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.videoSourcePlayer1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.picCapture, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lstMsg, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 485);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClosePort);
            this.panel1.Controls.Add(this.btnOpenPort);
            this.panel1.Controls.Add(this.btnRefreshPort);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboSP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboCam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseCam);
            this.panel1.Controls.Add(this.btnOpenCam);
            this.panel1.Controls.Add(this.txtImg);
            this.panel1.Controls.Add(this.btnCapturePic);
            this.panel1.Controls.Add(this.btnReadBarcode);
            this.panel1.Location = new System.Drawing.Point(571, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 179);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "CAM:";
            // 
            // comboCam
            // 
            this.comboCam.FormattingEnabled = true;
            this.comboCam.Location = new System.Drawing.Point(49, 12);
            this.comboCam.Name = "comboCam";
            this.comboCam.Size = new System.Drawing.Size(138, 20);
            this.comboCam.TabIndex = 15;
            this.comboCam.SelectedIndexChanged += new System.EventHandler(this.comboCam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "Img Path:";
            // 
            // btnCloseCam
            // 
            this.btnCloseCam.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseCam.FlatAppearance.BorderSize = 0;
            this.btnCloseCam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCloseCam.Location = new System.Drawing.Point(277, 4);
            this.btnCloseCam.Name = "btnCloseCam";
            this.btnCloseCam.Size = new System.Drawing.Size(69, 35);
            this.btnCloseCam.TabIndex = 10;
            this.btnCloseCam.Text = "Close Cam";
            this.btnCloseCam.UseVisualStyleBackColor = false;
            this.btnCloseCam.EnabledChanged += new System.EventHandler(this.btnCloseCam_EnabledChanged);
            this.btnCloseCam.Click += new System.EventHandler(this.btnCloseCam_Click);
            // 
            // btnOpenCam
            // 
            this.btnOpenCam.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenCam.FlatAppearance.BorderSize = 0;
            this.btnOpenCam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenCam.Location = new System.Drawing.Point(193, 4);
            this.btnOpenCam.Name = "btnOpenCam";
            this.btnOpenCam.Size = new System.Drawing.Size(78, 35);
            this.btnOpenCam.TabIndex = 9;
            this.btnOpenCam.Text = "Open Cam";
            this.btnOpenCam.UseVisualStyleBackColor = false;
            this.btnOpenCam.EnabledChanged += new System.EventHandler(this.btnOpenCam_EnabledChanged);
            this.btnOpenCam.Click += new System.EventHandler(this.btnOpenCam_Click);
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(79, 45);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(462, 21);
            this.txtImg.TabIndex = 12;
            this.txtImg.DoubleClick += new System.EventHandler(this.txtImg_DoubleClick);
            // 
            // btnCapturePic
            // 
            this.btnCapturePic.BackColor = System.Drawing.SystemColors.Control;
            this.btnCapturePic.FlatAppearance.BorderSize = 0;
            this.btnCapturePic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCapturePic.Location = new System.Drawing.Point(352, 4);
            this.btnCapturePic.Name = "btnCapturePic";
            this.btnCapturePic.Size = new System.Drawing.Size(106, 35);
            this.btnCapturePic.TabIndex = 11;
            this.btnCapturePic.Text = "Capture Picture";
            this.btnCapturePic.UseVisualStyleBackColor = false;
            this.btnCapturePic.EnabledChanged += new System.EventHandler(this.btnCapturePic_EnabledChanged);
            this.btnCapturePic.Click += new System.EventHandler(this.btnCapturePic_Click);
            // 
            // btnReadBarcode
            // 
            this.btnReadBarcode.BackColor = System.Drawing.SystemColors.Control;
            this.btnReadBarcode.FlatAppearance.BorderSize = 0;
            this.btnReadBarcode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnReadBarcode.Location = new System.Drawing.Point(464, 4);
            this.btnReadBarcode.Name = "btnReadBarcode";
            this.btnReadBarcode.Size = new System.Drawing.Size(94, 35);
            this.btnReadBarcode.TabIndex = 13;
            this.btnReadBarcode.Text = "Read Barcode";
            this.btnReadBarcode.UseVisualStyleBackColor = false;
            this.btnReadBarcode.Click += new System.EventHandler(this.btnReadBarcode_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboSP
            // 
            this.comboSP.FormattingEnabled = true;
            this.comboSP.Location = new System.Drawing.Point(89, 80);
            this.comboSP.Name = "comboSP";
            this.comboSP.Size = new System.Drawing.Size(121, 20);
            this.comboSP.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 18;
            this.label3.Text = "SerialPort:";
            // 
            // btnRefreshPort
            // 
            this.btnRefreshPort.BackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshPort.FlatAppearance.BorderSize = 0;
            this.btnRefreshPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshPort.Location = new System.Drawing.Point(378, 72);
            this.btnRefreshPort.Name = "btnRefreshPort";
            this.btnRefreshPort.Size = new System.Drawing.Size(97, 35);
            this.btnRefreshPort.TabIndex = 19;
            this.btnRefreshPort.Text = "Refresh Port";
            this.btnRefreshPort.UseVisualStyleBackColor = false;
            this.btnRefreshPort.Click += new System.EventHandler(this.btnRefreshPort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenPort.FlatAppearance.BorderSize = 0;
            this.btnOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOpenPort.Location = new System.Drawing.Point(216, 72);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(73, 35);
            this.btnOpenPort.TabIndex = 20;
            this.btnOpenPort.Text = "Open Port";
            this.btnOpenPort.UseVisualStyleBackColor = false;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // btnClosePort
            // 
            this.btnClosePort.BackColor = System.Drawing.SystemColors.Control;
            this.btnClosePort.FlatAppearance.BorderSize = 0;
            this.btnClosePort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClosePort.Location = new System.Drawing.Point(295, 72);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(77, 35);
            this.btnClosePort.TabIndex = 21;
            this.btnClosePort.Text = "Close Port";
            this.btnClosePort.UseVisualStyleBackColor = false;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 505);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloseCam;
        private System.Windows.Forms.Button btnOpenCam;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.Button btnCapturePic;
        private System.Windows.Forms.Button btnReadBarcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboCam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboSP;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.Button btnRefreshPort;
        private System.Windows.Forms.Button btnClosePort;
    }
}

