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
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timerDelay = new System.Windows.Forms.Timer(this.components);
            this.btnOpenCam = new System.Windows.Forms.Button();
            this.btnCloseCam = new System.Windows.Forms.Button();
            this.btnCapturePic = new System.Windows.Forms.Button();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.btnReadBarcode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            this.SuspendLayout();
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackColor = System.Drawing.Color.Black;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(2, 3);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(400, 300);
            this.videoSourcePlayer1.TabIndex = 0;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
            // 
            // timerDelay
            // 
            this.timerDelay.Interval = 10;
            this.timerDelay.Tick += new System.EventHandler(this.timerDelay_Tick);
            // 
            // btnOpenCam
            // 
            this.btnOpenCam.Location = new System.Drawing.Point(419, 12);
            this.btnOpenCam.Name = "btnOpenCam";
            this.btnOpenCam.Size = new System.Drawing.Size(78, 38);
            this.btnOpenCam.TabIndex = 1;
            this.btnOpenCam.Text = "Open Cam";
            this.btnOpenCam.UseVisualStyleBackColor = true;
            this.btnOpenCam.Click += new System.EventHandler(this.btnOpenCam_Click);
            // 
            // btnCloseCam
            // 
            this.btnCloseCam.Location = new System.Drawing.Point(503, 12);
            this.btnCloseCam.Name = "btnCloseCam";
            this.btnCloseCam.Size = new System.Drawing.Size(69, 38);
            this.btnCloseCam.TabIndex = 2;
            this.btnCloseCam.Text = "Close Cam";
            this.btnCloseCam.UseVisualStyleBackColor = true;
            this.btnCloseCam.Click += new System.EventHandler(this.btnCloseCam_Click);
            // 
            // btnCapturePic
            // 
            this.btnCapturePic.Location = new System.Drawing.Point(578, 12);
            this.btnCapturePic.Name = "btnCapturePic";
            this.btnCapturePic.Size = new System.Drawing.Size(115, 38);
            this.btnCapturePic.TabIndex = 3;
            this.btnCapturePic.Text = "Capture Picture";
            this.btnCapturePic.UseVisualStyleBackColor = true;
            this.btnCapturePic.Click += new System.EventHandler(this.btnCapturePic_Click);
            // 
            // picCapture
            // 
            this.picCapture.BackColor = System.Drawing.Color.Gray;
            this.picCapture.Location = new System.Drawing.Point(2, 309);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(400, 300);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 4;
            this.picCapture.TabStop = false;
            // 
            // txtImg
            // 
            this.txtImg.Location = new System.Drawing.Point(419, 66);
            this.txtImg.Name = "txtImg";
            this.txtImg.Size = new System.Drawing.Size(274, 21);
            this.txtImg.TabIndex = 5;
            this.txtImg.DoubleClick += new System.EventHandler(this.txtImg_DoubleClick);
            // 
            // lstMsg
            // 
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 12;
            this.lstMsg.Location = new System.Drawing.Point(419, 149);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(274, 460);
            this.lstMsg.TabIndex = 6;
            // 
            // btnReadBarcode
            // 
            this.btnReadBarcode.Location = new System.Drawing.Point(419, 93);
            this.btnReadBarcode.Name = "btnReadBarcode";
            this.btnReadBarcode.Size = new System.Drawing.Size(115, 38);
            this.btnReadBarcode.TabIndex = 7;
            this.btnReadBarcode.Text = "Read Barcode";
            this.btnReadBarcode.UseVisualStyleBackColor = true;
            this.btnReadBarcode.Click += new System.EventHandler(this.btnReadBarcode_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 624);
            this.Controls.Add(this.btnReadBarcode);
            this.Controls.Add(this.lstMsg);
            this.Controls.Add(this.txtImg);
            this.Controls.Add(this.picCapture);
            this.Controls.Add(this.btnCapturePic);
            this.Controls.Add(this.btnCloseCam);
            this.Controls.Add(this.btnOpenCam);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Timer timerDelay;
        private System.Windows.Forms.Button btnOpenCam;
        private System.Windows.Forms.Button btnCloseCam;
        private System.Windows.Forms.Button btnCapturePic;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.TextBox txtImg;
        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.Button btnReadBarcode;
    }
}

