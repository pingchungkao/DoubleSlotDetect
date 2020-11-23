using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace DoubleSlotDetect
{
    public partial class MainForm : Form
    {
        public List<CameraBasic> _cameraList = new List<CameraBasic>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i<2; i++)
            {
                CameraBasic cameraBasic = new CameraBasic
                {
                    Cap = new VideoCapture(i),
                    MatFrame = new Mat()
                };

                cameraBasic.Cap.SetCaptureProperty(CapProp.AutoExposure, 0);
                cameraBasic.Cap.SetCaptureProperty(CapProp.AutoWb, 0);
                cameraBasic.Cap.SetCaptureProperty(CapProp.Exposure, -5);

                switch(i)
                {
                    case 0:
                        cameraBasic.Cap.SetCaptureProperty(CapProp.FrameWidth, 640); //設置寬度
                        cameraBasic.Cap.SetCaptureProperty(CapProp.FrameHeight, 480);//設置高度

                        break;
                    case 1:
                        cameraBasic.Cap.SetCaptureProperty(CapProp.FrameWidth, 640); //設置寬度
                        cameraBasic.Cap.SetCaptureProperty(CapProp.FrameHeight, 480);//設置高度

                        break;
                }

                AOITool aoiTool = new AOITool();
                cameraBasic.Tool = aoiTool;

                _cameraList.Add(cameraBasic);
            }
            _cameraList[0].Cap.ImageGrabbed += ImageGrabbed_0;
            _cameraList[1].Cap.ImageGrabbed += ImageGrabbed_1;

            CCD1DisplayimageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            CCD2DisplayimageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
        }
        private void ImageGrabbed_0(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = _cameraList[0];
            cameraBasic.Cap.Retrieve(cameraBasic.MatFrame);

            //this.BeginInvoke((MethodInvoker)delegate
            //{
                CCD1DisplayimageBox.Image = cameraBasic.MatFrame;
                System.Threading.Thread.Sleep(50);
            //});
        }
        private void ImageGrabbed_1(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = _cameraList[1];

            cameraBasic.Cap.Retrieve(cameraBasic.MatFrame);

            //this.BeginInvoke((MethodInvoker)delegate
            //{
                CCD2DisplayimageBox.Image = cameraBasic.MatFrame;
                System.Threading.Thread.Sleep(50);
            //});

        }

        private void CCD1Livebutton_Click(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = null;
            Button btnObj = (Button)sender;

            switch(btnObj.Name)
            {
                case "CCD1Livebutton":
                    cameraBasic = _cameraList[0];
                    break;

                case "CCD2Livebutton":
                    cameraBasic = _cameraList[1];
                    break;

                default:
                    break;
            }

            if(cameraBasic != null)
            {
                cameraBasic.IsLive = !cameraBasic.IsLive;

                if(cameraBasic.IsLive)
                {
                    cameraBasic.Cap.Start();

                    btnObj.Text = "Stop";
                }
                else
                {
                    cameraBasic.Cap.Stop();

                    btnObj.Text = "Live";
                }
            }
        }

        private void CCD1Grabbutton_Click(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = null;
            Button btnObj = (Button)sender;

            switch (btnObj.Name)
            {
                case "CCD1Grabbutton":
                    cameraBasic = _cameraList[0];
                    break;

                case "CCD2Grabbutton":
                    cameraBasic = _cameraList[1];
                    break;

                default:
                    break;
            }

            cameraBasic?.Cap.Grab();
        }

        private void CCD1SetupButton_Click(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = null;
            Button btnObj = (Button)sender;

            switch (btnObj.Name)
            {
                case "CCD1SetupButton":
                    cameraBasic = _cameraList[0];
                    break;

                case "CCD2SetupButton":
                    cameraBasic = _cameraList[1];
                    break;

                default:
                    break;
            }

            using (AOIToolSetupForm ToolSetupForm = new AOIToolSetupForm(cameraBasic))
            {
                ToolSetupForm.ShowDialog();
            }            
        }

        private void CCD1Savebutton_Click(object sender, EventArgs e)
        {
            CameraBasic cameraBasic = null;
            Button btnObj = (Button)sender;

            switch (btnObj.Name)
            {
                case "CCD1SaveButton":
                    cameraBasic = _cameraList[0];
                    break;

                case "CCD2SaveButton":
                    cameraBasic = _cameraList[1];
                    break;

                default:
                    break;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Bitmap Image|*.bmp",
                FileName = "Image0",//設定預設檔名
                DefaultExt = "bmp",//設定預設格式（可以不設）
                AddExtension = true//設定自動在檔名中新增副檔名
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(sfd.FileName, cameraBasic.MatFrame);
            }

        }

        private void CCD1LoadButton_Click(object sender, EventArgs e)
        {
            ImageBox DisplayimageBox = null;
            CameraBasic cameraBasic = null;
            Button btnObj = (Button)sender;

            switch (btnObj.Name)
            {
                case "CCD1LoadButton":
                    cameraBasic = _cameraList[0];
                    DisplayimageBox = CCD1DisplayimageBox;
                    break;

                case "CCD2LoadButton":
                    cameraBasic = _cameraList[1];
                    DisplayimageBox = CCD2DisplayimageBox;
                    break;

                default:
                    break;
            }

            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Select Image",
                InitialDirectory = "D:\\", 
                Filter = "Bitmap Image|*.bmp",
                DefaultExt = "bmp"//設定預設格式（可以不設）
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                cameraBasic.MatFrame = CvInvoke.Imread(ofd.FileName);
                DisplayimageBox.Image = cameraBasic.MatFrame;
                DisplayimageBox.Refresh();
            }
        }
    }
}
