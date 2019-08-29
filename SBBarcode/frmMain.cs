using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using DTKBarReaderLib;
using System.Runtime.InteropServices;
using Edward;
using System.IO;
using System.IO.Ports;




namespace SBBarcode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        [DllImport("DTKBarReader.dll", CharSet = CharSet.Unicode), PreserveSig]
        private static extern int CreateBarcodeReader(ref BarcodeReader barReader);
        [DllImport("DTKBarReader.dll", CharSet = CharSet.Unicode), PreserveSig]
        private static extern int DestroyBarcodeReader(BarcodeReader barReader);

        [DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        BarcodeReader barReader = null;

        public string SN = string.Empty;
        public string MAC = string.Empty;

        /// <summary>
        /// 类别的一个列表看到AForge.Video.DirectShow.FilterCategory。
        ///样本用法:
        ///列举videoDevices =新FilterInfoCollection(FilterCategory.VideoInputDevice视频设备);
        ///列出设备(视频设备中的FilterInfo设备)
        /// </summary>
        //定义收集过滤器信息的对象
        FilterInfoCollection videoDevices;

        /// <summary>
        /// 这个视频源类从本地视频捕获设备获取视频数据，
        /// 像USB网络摄像头(或内部)、帧抓取器、捕捉板——任何东西
        /// 支持DirectShow的接口。对于有快门按钮的设备
        /// 或者支持外部软件触发，类也允许做快照。
        /// 视频大小和快照大小都可以配置。
        /// </summary>
        //定义视频源抓取类
        VideoCaptureDevice videoSource;
        //定义下标
        public int selectedDeviceIndex = 0;

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            getSerialPort(comboSP);
            this.Text = "Scan Mac(Code-128) & SN(DataMatrix),ver:" + Application.ProductVersion;
            btnCloseCam.Enabled = false;
            btnCapturePic.Enabled = false;
            btnClosePort.Enabled = false;
            txtImg.SetWatermark("Double Click here to select image file.");

            if (!Directory.Exists("Pictures"))
                Directory.CreateDirectory("Pictures");



            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count > 0)
            {

                for (int i = 0; i < videoDevices.Count ; i++)
                {
                    comboCam.Items.Add(videoDevices[i].Name);
                }

                comboCam.SelectedIndex = 0;
                selectedDeviceIndex = 0;


            }


            DeleteLog();
            if (p.RunType == p.RunTypeFlag.Auto)
            {
                if (p.CamIndex > videoDevices.Count-1)
                {
                    p.WriteLog("Select Cam index(" + p.CamIndex.ToString() +") out of local cam index range (" + (videoDevices.Count -1).ToString () +").");
                }
                else
                {
                    comboCam.SelectedIndex = p.CamIndex;
                    selectedDeviceIndex = p.CamIndex;

                    OpenCam();
                    p.WriteLog("Auto Open Cam.");
                    System.Threading.Thread.Sleep(1500);
                    CapturePic();
                    CloseCam();
                    ReadBarcode();
                    System.Threading.Thread.Sleep(500);
                    p.WriteLog("Auto Run Exit.");
                }


                Environment.Exit(0);
            }

        }


        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            OpenCam();
            p.WriteLog("Manual Open Cam.");
        }

        private void OpenCam()
        {
            //实例化过滤类
            //FilterCategory.VideoInputDevice视频输入设备类别。
          
            //实例化下标
            
            //实例化视频源抓取类
            //videoDevices[selectedDeviceIndex].MonikerString   过滤器的名字的字符串。
            videoSource = new VideoCaptureDevice(videoDevices[selectedDeviceIndex].MonikerString);//连接摄像头
            //视频分辨设置
            //该属性允许设置一个支持的视频分辨率
            //相机。使用AForge.Video.DirectShow.VideoCaptureDevice.VideoCapabilities
            //属性以获得支持的视频分辨率列表。
            //在照相机开始生效之前必须设置好该属性。
            //属性的默认值设置为null，这意味着默认的视频分辨率
            //使用。
            videoSource.VideoResolution = videoSource.VideoCapabilities[selectedDeviceIndex];
            //把实例化好的videosource类赋值到VideoSourcePlayer控件的VideoSource属性
            // vspxianshi.VideoSource = videoSource;
            videoSourcePlayer1.VideoSource = videoSource;
            //启动VideoSourcePlayer控件
            //vspxianshi.Start();
            videoSourcePlayer1.Start();
            //这样就把摄像头的图像获取到了本地
            System.Threading.Thread.Sleep(500);
            UpdateMsg(lstMsg, "Open cam.");
            btnCloseCam.Enabled = true;
            btnOpenCam.Enabled = false;
            btnCapturePic.Enabled = true;
            comboCam.Enabled = false;

            SN = string.Empty;
            MAC = string.Empty;
        }

        private void btnCloseCam_Click(object sender, EventArgs e)
        {

            CloseCam();
            p.WriteLog("Manual Close Cam.");
        }

        private void CloseCam()
        {
            videoSourcePlayer1.Stop();
            timerDelay.Stop();
            btnOpenCam.Enabled = true;
            btnCloseCam.Enabled = false;
            btnCapturePic.Enabled = false;
            comboCam.Enabled = true;
            UpdateMsg(lstMsg, "Close cam.");
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (videoSource == null)
            {
                return;
            }
            else
            {
                try
                {
                    //创建图像对象
                    Bitmap bm1 = videoSourcePlayer1.GetCurrentVideoFrame();
                    Bitmap bm2 = new Bitmap(bm1.Width, bm1.Height);
                    Graphics g = Graphics.FromImage(bm2);
                    g.DrawImageUnscaled(bm1, 0, 0);
                    //get rid of the graphics
                    g.Dispose();
                    //and save a new gif
                   // bm2.Save("001.jpg", ImageFormat.Jpeg);
                    //pbboxpot.ImageLocation = "001.jpg";
                }
                catch (Exception)
                {
                    MessageBox.Show("您的摄像头有问题,请您重新试一次!");
                }

            }
        }

        private void btnCapturePic_Click(object sender, EventArgs e)
        {
            CapturePic();
        }


        private void CapturePic()
        {
            if (videoSource == null)
            {
                return;
            }
            else
            {
                //创建图像对象
                Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                //定义图片路径
                string filename =   DateTime.Now.ToString("yyyyMMddHHmmss") + ".bmp";
                //创建图片
                bitmap.Save(Environment.CurrentDirectory + @"\Pictures\" + filename, ImageFormat.Bmp);
                txtImg.Text = Environment.CurrentDirectory + @"\Pictures\" + filename;
                picCapture.ImageLocation = Environment.CurrentDirectory + @"\Pictures\" + filename;
                //txtImg.Text = @"C:\Users\Administrator\Desktop\11.bmp";
                //picCapture.ImageLocation = @"C:\Users\Administrator\Desktop\11.bmp";
                UpdateMsg(lstMsg, "capture " + filename);
                p.WriteLog("capture " + filename);
            }
        }

        private void UpdateMsg(ListBox listbox,string msg)
        {

            string item = DateTime.Now.ToString("HH:mm:ss") + "->" + msg;
            listbox.Items.Add(item);
            listbox.SelectedIndex = listbox.Items.Count - 1;
            if (listbox.Items.Count >=100)
                listbox.Items.RemoveAt(0);

        }



        /// <summary>
        /// 条码识别
        /// </summary>
        private void ScanBarCode(string fileName)
        {
            DateTime now = DateTime.Now;
            System.Drawing.Image primaryImage = System.Drawing.Image.FromFile(fileName);

            Bitmap pImg = MakeGrayscale3((Bitmap)primaryImage);
            using (ZBar.ImageScanner scanner = new ZBar.ImageScanner())
            {
                scanner.SetConfiguration(ZBar.SymbolType.None, ZBar.Config.Enable, 0);
                scanner.SetConfiguration(ZBar.SymbolType.CODE39, ZBar.Config.Enable, 1);
                scanner.SetConfiguration(ZBar.SymbolType.CODE128, ZBar.Config.Enable, 1);

                List<ZBar.Symbol> symbols = new List<ZBar.Symbol>();
                symbols = scanner.Scan((System.Drawing.Image)pImg);

                if (symbols != null && symbols.Count > 0)
                {
                    string result = string.Empty;
                    symbols.ForEach(s => result += "条码内容:" + s.Data + " 条码质量:" + s.Quality + Environment.NewLine);
                    //  MessageBox.Show(result);

                    foreach (ZBar.Symbol sym in symbols)
                    {
                        UpdateMsg(lstMsg, "条码内容:" + sym.Data + " 条码质量:" + sym.Quality);
                        p.WriteLog("MAC.txt", sym.Data);
                        p.WriteLog("MAC:" + sym.Data + ",Quality:" + sym.Quality);
                        MAC = sym.Data;
                    }
                }
                else
                {
                    UpdateMsg(lstMsg, "一维码读取失败.");
                }
            }
        }


        /// <summary>
        /// 处理图片灰度
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        private  Bitmap MakeGrayscale3(Bitmap original)
        {
            //create a blank bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            //get a graphics object from the new image
            Graphics g = Graphics.FromImage(newBitmap);

            //create the grayscale ColorMatrix
            System.Drawing.Imaging.ColorMatrix colorMatrix = new System.Drawing.Imaging.ColorMatrix(
               new float[][] 
              {
                 new float[] {.3f, .3f, .3f, 0, 0},
                 new float[] {.59f, .59f, .59f, 0, 0},
                 new float[] {.11f, .11f, .11f, 0, 0},
                 new float[] {0, 0, 0, 1, 0},
                 new float[] {0, 0, 0, 0, 1}
              });

            //create some image attributes
            ImageAttributes attributes = new ImageAttributes();

            //set the color matrix attribute
            attributes.SetColorMatrix(colorMatrix);

            //draw the original image on the new image
            //using the grayscale color matrix
            g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
               0, 0, original.Width, original.Height, GraphicsUnit.Pixel, attributes);

            //dispose the Graphics object
            g.Dispose();
            return newBitmap;
        }

        private void btnReadBarcode_Click(object sender, EventArgs e)
        {

            ReadBarcode();
        }


        private void ReadBarcode()
        {
            if (!string.IsNullOrEmpty(txtImg.Text.Trim()))
            {
                ScanBarCode(txtImg.Text.Trim());

                barReader = new BarcodeReader();
                // set barcode types to read 
                barReader.BarcodeTypes = BarcodeTypeEnum.BT_DataMatrix;
                // define expected barcode orientations
                barReader.BarcodeOrientation = BarcodeOrientationEnum.BO_All;
                // the following values are default values (for TM_Multiple only)
                // for example, if barReader.Threshold = 128, 
                //      then the follwong thresholds will be used 64,80,96,112,128,144,160,176,192
                barReader.ThresholdStep = 16;
                barReader.ThresholdCount = 8;
                barReader.ReadFromFile(txtImg.Text.Trim());

                if (barReader.Barcodes.Count == 0)
                    UpdateMsg(lstMsg, "No barcodes found");
                else
                {
                    for (int i = 0; i < barReader.Barcodes.Count; i++)
                    {
                        Barcode barcode = barReader.Barcodes.get_Item(i);
                        UpdateMsg(lstMsg, barcode.BarcodeString);
                        p.WriteLog("SN.txt", barcode.BarcodeString);
                        p.WriteLog("SN:" + barcode.BarcodeString);
                        SN = barcode.BarcodeString;
                    }
                }

            }
        }
        private void txtImg_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImg.Text = open.FileName;
                picCapture.Load(txtImg.Text.Trim());
            }

        }

        private void btnCapturePic_EnabledChanged(object sender, EventArgs e)
        {
            if (btnCapturePic.Enabled)
                btnCapturePic.BackColor = Color.FromArgb(51, 153, 255);
            else
                btnCapturePic.BackColor = Color.Gray;
        }

        private void btnCloseCam_EnabledChanged(object sender, EventArgs e)
        {
            if (btnCloseCam.Enabled)
                btnCloseCam.BackColor = Color.FromArgb(51, 153, 255);
            else
                btnCloseCam.BackColor = Color.Gray;
        }

        private void btnOpenCam_EnabledChanged(object sender, EventArgs e)
        {
            if (btnOpenCam.Enabled)
                btnOpenCam.BackColor = Color.FromArgb(51, 153, 255);
            else
                btnOpenCam.BackColor = Color.Gray;
        }







        /// <summary>
        /// 
        /// </summary>
        private void DeleteLog()
        {

            if (File.Exists("MAC.txt"))
                File.Delete("MAC.txt");
            if (File.Exists("SN.txt"))
                File.Delete("SN.txt");

        }

        private void comboCam_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDeviceIndex = comboCam.SelectedIndex;
        }


        /// <summary>
        /// 获取串口 
        /// </summary>
        /// <param name="combox"></param>
        private void getSerialPort(ComboBox combox)
        {
            combox.Items.Clear();
            combox.Text = string.Empty;
            foreach (string sp in System.IO.Ports.SerialPort.GetPortNames())
                combox.Items.Add(sp);

            if (combox.Items.Count > 0)
                combox.SelectedIndex = 0;


        }

        private void btnRefreshPort_Click(object sender, EventArgs e)
        {
            getSerialPort(comboSP);
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboSP.Text.Trim()))
            {
                UpdateMsg(lstMsg, "select a comport first please...");
                return;
            }

            serialPort1.PortName = comboSP.Text.Trim();
            try
            {
                serialPort1.Open();
                UpdateMsg(lstMsg, serialPort1.PortName + " is open...");
                btnOpenPort.Enabled = false;
                btnClosePort.Enabled = true;
                btnRefreshPort.Enabled = false;
            }
            catch (Exception ex)
            {
                UpdateMsg(lstMsg, serialPort1.PortName + " failed to open...");
                UpdateMsg(lstMsg, ex.Message);
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                    serialPort1.Close();
                UpdateMsg(lstMsg, serialPort1.PortName + " is closed...");
                btnOpenPort.Enabled = true;
                btnClosePort.Enabled = false;
                btnRefreshPort.Enabled = true;
            }
            catch (Exception ex)
            {
                UpdateMsg(lstMsg, serialPort1.PortName + " failed to  closed...");
                UpdateMsg(lstMsg, ex.Message);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke((EventHandler)(delegate
            {
                if (serialPort1.BytesToRead == 0)
                    return;
                Delay(50);
                string result = string.Empty;

                result = serialPort1.ReadExisting().Trim().ToUpper();
                serialPort1.DiscardInBuffer();

                UpdateMsg(lstMsg, "recevive:" + result);

                if (result == "A")
                {
                    if (p.CamIndex > videoDevices.Count - 1)
                    {
                        p.WriteLog("Select Cam index(" + p.CamIndex.ToString() + ") out of local cam index range (" + (videoDevices.Count - 1).ToString() + ").");
                    }
                    else
                    {
                        comboCam.SelectedIndex = p.CamIndex;
                        selectedDeviceIndex = p.CamIndex;

                        OpenCam();
                        p.WriteLog("Auto Open Cam.");
                        System.Threading.Thread.Sleep(1500);
                        CapturePic();
                        CloseCam();
                        ReadBarcode();
                        System.Threading.Thread.Sleep(500);
                        if (string.IsNullOrEmpty(SN))
                        {
                            UpdateMsg(lstMsg, "SN is empty...");
                            serialPort1.DiscardOutBuffer();
                            serialPort1.Write("SN");
                            UpdateMsg(lstMsg, "Send SN");
                        }
                        else
                        {
                            serialPort1.DiscardOutBuffer();
                            serialPort1.Write(SN);
                            UpdateMsg(lstMsg, "Send " + SN);
                        }
                    }
                }

                if (result == "B")
                {
                    if (p.CamIndex > videoDevices.Count - 1)
                    {
                        p.WriteLog("Select Cam index(" + p.CamIndex.ToString() + ") out of local cam index range (" + (videoDevices.Count - 1).ToString() + ").");
                    }
                    else
                    {
                        comboCam.SelectedIndex = p.CamIndex;
                        selectedDeviceIndex = p.CamIndex;

                        OpenCam();
                        p.WriteLog("Auto Open Cam.");
                        System.Threading.Thread.Sleep(1500);
                        CapturePic();
                        CloseCam();
                        ReadBarcode();
                        System.Threading.Thread.Sleep(500);
                        if (string.IsNullOrEmpty(MAC))
                        {
                            serialPort1.DiscardOutBuffer();
                            UpdateMsg(lstMsg, "MAC is empty...");
                            serialPort1.Write("AMC");
                            UpdateMsg(lstMsg, "Send MAC");
                        }
                        else
                        {
                            serialPort1.DiscardOutBuffer();
                            serialPort1.Write(MAC);
                            UpdateMsg(lstMsg, "Send " + MAC);
                        }
 
                    }
                }
    


            }));
        }

        #region 延時子程式

        /// <summary>
        /// 延時子程序
        /// </summary>
        /// <param name="interval">延時的時間，单位毫秒</param>
        private void Delay(double interval)
        {
            DateTime time = DateTime.Now;
            double span = interval * 10000;
            while (DateTime.Now.Ticks - time.Ticks < span)
            {
                Application.DoEvents();
            }

        }

        #endregion
    }
}
