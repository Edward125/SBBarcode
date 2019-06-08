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


namespace SBBarcode
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


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

        }

        private void btnOpenCam_Click(object sender, EventArgs e)
        {
            //实例化过滤类
            //FilterCategory.VideoInputDevice视频输入设备类别。
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //实例化下标
            selectedDeviceIndex = 0;
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
        }

        private void btnCloseCam_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Stop();
            timerDelay.Stop();

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
            if (videoSource == null)
            {
                return;
            }
            else
            {
                //创建图像对象
                Bitmap bitmap = videoSourcePlayer1.GetCurrentVideoFrame();
                //定义图片路径
                string filename = "jietu.jpg";
                //创建图片
                bitmap.Save(filename, ImageFormat.Jpeg);
                picCapture.ImageLocation = filename;
            }
        }
    }
}
