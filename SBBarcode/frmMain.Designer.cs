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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCloseCam = new System.Windows.Forms.Button();
            this.btnOpenCam = new System.Windows.Forms.Button();
            this.txtImg = new System.Windows.Forms.TextBox();
            this.btnCapturePic = new System.Windows.Forms.Button();
            this.btnReadBarcode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // btnCloseCam
            // 
            this.btnCloseCam.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCloseCam.FlatAppearance.BorderSize = 0;
            this.btnCloseCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCam.Location = new System.Drawing.Point(103, 4);
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
            this.btnOpenCam.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpenCam.FlatAppearance.BorderSize = 0;
            this.btnOpenCam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCam.Location = new System.Drawing.Point(19, 3);
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
            this.btnCapturePic.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCapturePic.FlatAppearance.BorderSize = 0;
            this.btnCapturePic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapturePic.Location = new System.Drawing.Point(178, 4);
            this.btnCapturePic.Name = "btnCapturePic";
            this.btnCapturePic.Size = new System.Drawing.Size(115, 35);
            this.btnCapturePic.TabIndex = 11;
            this.btnCapturePic.Text = "Capture Picture";
            this.btnCapturePic.UseVisualStyleBackColor = false;
            this.btnCapturePic.EnabledChanged += new System.EventHandler(this.btnCapturePic_EnabledChanged);
            this.btnCapturePic.Click += new System.EventHandler(this.btnCapturePic_Click);
            // 
            // btnReadBarcode
            // 
            this.btnReadBarcode.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnReadBarcode.FlatAppearance.BorderSize = 0;
            this.btnReadBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadBarcode.Location = new System.Drawing.Point(299, 4);
            this.btnReadBarcode.Name = "btnReadBarcode";
            this.btnReadBarcode.Size = new System.Drawing.Size(115, 35);
            this.btnReadBarcode.TabIndex = 13;
            this.btnReadBarcode.Text = "Read Barcode";
            this.btnReadBarcode.UseVisualStyleBackColor = false;
            this.btnReadBarcode.Click += new System.EventHandler(this.btnReadBarcode_Click);
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 505);
            this.Controls.Add(this.tableLayoutPanel1);
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
    }
}

