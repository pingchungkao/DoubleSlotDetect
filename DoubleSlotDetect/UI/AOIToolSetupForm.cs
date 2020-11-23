using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV.UI;
using Emgu.CV.CvEnum;

namespace DoubleSlotDetect
{
    public partial class AOIToolSetupForm : Form
    {
        private CameraBasic _cameraBasic;
        /// <summary>
        /// X方向影像縮放
        /// </summary>
        private double ZoomRadioX;

        /// <summary>
        /// Y方向影像縮放
        /// </summary>
        private double ZoomRadioY;

        /// <summary>
        /// Rect的起始點
        /// </summary>
        private Point StartROI;

        /// <summary>
        /// 劃出Rect的位置
        /// </summary>
        private Rectangle Rect;
        private bool IsMouseDown = false;
        private bool SelectROI = false;

        private bool IsUpdateUI = false;

        public AOIToolSetupForm(CameraBasic cameraBasic)
        {
            InitializeComponent();

            _cameraBasic = cameraBasic;
            _cameraBasic.Tool.SetImage(_cameraBasic.MatFrame);

            ZoomRadioX = (double)DisplayImageBox.Width / (double)_cameraBasic.Cap.Width;
            ZoomRadioY = (double)DisplayImageBox.Height / (double)_cameraBasic.Cap.Height;
        }

        private void AOIToolSetupForm_Load(object sender, EventArgs e)
        {
            DisplayImageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            DisplayImageBox.Image = _cameraBasic.MatFrame;

            FilterImageBox.FunctionalMode = ImageBox.FunctionalModeOption.Minimum;
            FilterImageBox.Parent = DisplayImageBox;

            UpdateUI();
            UpdateROI();

            if(Rect == null || Rect.X < 0 || Rect.Y < 0 || Rect.Width <= 0 || Rect.Height <= 0)
            {
                pnSetup.Enabled = false;
            }
            else
            {
                pnSetup.Enabled = true;
            }

        }

        private void DisplayImageBox_MouseMove(object sender, MouseEventArgs e)
        {
            //轉換為實際影像位置
            PositionStripStatus.Text = "X:" + (e.X/ ZoomRadioX).ToString() + ", Y:" + (e.Y/ ZoomRadioY).ToString();

            if(IsMouseDown)
            {
                int width = Math.Max(StartROI.X ,e.X) - Math.Min(StartROI.X ,e.X);
                int height = Math.Max(StartROI.Y ,e.Y) - Math.Min(StartROI.Y, e.Y);

                Rect = new Rectangle(Math.Min(StartROI.X, e.X), Math.Min(StartROI.Y, e.Y), width, height);

                Refresh();
            }
        }

        private void DisplayImageBox_MouseDown(object sender, MouseEventArgs e)
        {
            if(SelectROI)
            {
                IsMouseDown = true;
                StartROI = e.Location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectROI = true;
            SelectROIButton.Enabled = false;

            FilterImageBox.Visible = false;

            if (pnSetup.Enabled == false)
                pnSetup.Enabled = true;

            Refresh();
        }

        private void DisplayImageBox_Paint(object sender, PaintEventArgs e)
        {
            if(SelectROI)
            {
                using (Pen pen = new Pen(Color.Red, 1))
                {
                    e.Graphics.DrawRectangle(pen, Rect);
                }
            }
        }

        private void DisplayImageBox_MouseUp(object sender, MouseEventArgs e)
        {
            if(SelectROI)
            {
                SelectROI = false;
                IsMouseDown = false;
                SelectROIButton.Enabled = true;

                Rectangle roi = new Rectangle
                {
                    Location = new Point((int)((double)Rect.Left / ZoomRadioX), (int)((double)Rect.Top / ZoomRadioY)),
                    Size = new Size((int)((double)(Rect.Right - Rect.Left) / ZoomRadioX), (int)((double)(Rect.Bottom - Rect.Top) / ZoomRadioY))
                };
                _cameraBasic.Tool.SetROI(roi);

                FilterImageBox.Visible = false;
                FilterImageBox.Location = new Point(Rect.X, Rect.Y); //窗體的起始位置為0,0 
                FilterImageBox.Size = new Size(Rect.Width, Rect.Height);

            }
        }

        private void ShowGrayButton_Click(object sender, EventArgs e)
        {
            Refresh();
            FilterImageBox.Visible = !FilterImageBox.Visible;

            if (FilterImageBox.Visible)
            {
                FilterImageBox.Image = _cameraBasic.Tool.DoGray();
            }

            FilterImageBox.Refresh();
        }

        private void GrayFilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;
            ComboBox cmbObj = (ComboBox)sender;

            _cameraBasic.Tool.FilterMode = (GrayFilter)cmbObj.SelectedIndex;

            FilterImageBox.Visible = true;

            FilterImageBox.Image = _cameraBasic.Tool.DoGray();

            FilterImageBox.Refresh();
        }

        private void ShowBinaryButton_Click(object sender, EventArgs e)
        {
            Refresh();
            FilterImageBox.Visible = !FilterImageBox.Visible;

            if (FilterImageBox.Visible)
            {
                FilterImageBox.Image = _cameraBasic.Tool.DoBinary();
            }

            FilterImageBox.Refresh();
        }

        private void ThresholdLowTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;

            TrackBar bar = (TrackBar)sender;

            switch(bar.Name)
            {
                case "ThresholdLowTrackBar":
                    if (byte.TryParse(bar.Value.ToString(), out _cameraBasic.Tool.ThresholdLow))
                    {
                        ThresholdLowLabel.Text = _cameraBasic.Tool.ThresholdLow.ToString();
                        FilterImageBox.Visible = true;
                    }

                    break;

                case "ThresholdHighTrackBar":
                    if (byte.TryParse(bar.Value.ToString(), out _cameraBasic.Tool.ThresholdHigh))
                    {
                        ThresholdHighLabel.Text = _cameraBasic.Tool.ThresholdHigh.ToString();
                        FilterImageBox.Visible = true;
                    }
                    break;
            }

            if (FilterImageBox.Visible)
            {
                FilterImageBox.Image = _cameraBasic.Tool.DoBinary();
                FilterImageBox.Refresh();
            }
        }

        private void UpdateUI()
        {
            if(_cameraBasic.Tool == null) return;
            //if(_cameraBasic.Tool == null) return;

            IsUpdateUI = true;

            GrayFilterComboBox.SelectedIndex = (int)_cameraBasic.Tool.FilterMode;

            ThresholdLowTrackBar.Value = _cameraBasic.Tool.ThresholdLow;
            ThresholdLowLabel.Text = _cameraBasic.Tool.ThresholdLow.ToString();

            ThresholdHighTrackBar.Value = _cameraBasic.Tool.ThresholdHigh;
            ThresholdHighLabel.Text = _cameraBasic.Tool.ThresholdHigh.ToString();

            IsUpdateUI = false;
        }

        private void UpdateROI()
        {
            Rectangle temproi = _cameraBasic.Tool.GetROI();

            Rect = new Rectangle
            {
                Location = new Point((int)(temproi.Left*ZoomRadioX), (int)(temproi.Top * ZoomRadioY)),
                Size = new Size((int)(temproi.Width * ZoomRadioX), (int)(temproi.Height * ZoomRadioY))
            };

            FilterImageBox.Visible = false;
            FilterImageBox.Location = new Point(Rect.X, Rect.Y); //窗體的起始位置為0,0 
            FilterImageBox.Size = new Size(Rect.Width, Rect.Height);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            FilterImageBox.Visible = false;
            Refresh();

            _cameraBasic.Tool.Inspect();

            using (Pen pen = new Pen(Color.Red, 2))
            {
                Graphics eGraphics = DisplayImageBox.CreateGraphics();

                foreach(BlobInfo blob in _cameraBasic.Tool.BlobList)
                {
                    Rectangle blobrect = new Rectangle
                    {
                        Location = new Point((int)(blob.Rect.Left * ZoomRadioX), (int)(blob.Rect.Top * ZoomRadioY)),
                        Size = new Size((int)(blob.Rect.Width * ZoomRadioX), (int)(blob.Rect.Height * ZoomRadioY))
                    };

                    eGraphics.DrawRectangle(pen, blobrect);
                }
            }


        }

        private void MorphOpComboBox0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;

            MorphologyExInfo exInfo = null;

            ComboBox ComboBox = (ComboBox)sender;
            exInfo = _cameraBasic.Tool.MorphologyExList[ComboBox.TabIndex];

            exInfo.Mode = (MorphOp)ComboBox.SelectedIndex;

            ShowInspectMatBinary();
        }

        private void ElementShapeComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;

            MorphologyExInfo exInfo = null;

            ComboBox ComboBox = (ComboBox)sender;
            exInfo = _cameraBasic.Tool.MorphologyExList[ComboBox.TabIndex];

            exInfo.MaskShape = (ElementShape)ComboBox.SelectedIndex;

            ShowInspectMatBinary();
        }

        private void MaskSizeNumeric1_ValueChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;

            MorphologyExInfo exInfo = null;

            NumericUpDown UpDown = (NumericUpDown)sender;

            exInfo = _cameraBasic.Tool.MorphologyExList[UpDown.TabIndex];
            exInfo.MaskSize = (int)UpDown.Value;

            ShowInspectMatBinary();
        }

        private void ShowInspectMatBinary()
        {
            FilterImageBox.Visible = true;

            _cameraBasic.Tool.Inspect();

            FilterImageBox.Image = _cameraBasic.Tool.MatBinary;

            FilterImageBox.Refresh();
        }
        private void MorphExecTimeNumeric1_ValueChanged(object sender, EventArgs e)
        {
            if (IsUpdateUI) return;

            MorphologyExInfo exInfo = null;

            NumericUpDown UpDown = (NumericUpDown)sender;

            exInfo = _cameraBasic.Tool.MorphologyExList[UpDown.TabIndex];
            exInfo.ExecTime = (int)UpDown.Value;

            ShowInspectMatBinary();
        }
    }
}
