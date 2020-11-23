using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Cvb;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;


//using Emgu.CV.W

namespace DoubleSlotDetect
{
    public enum GrayFilter
    {
        Gray = 0,
        B,
        G,
        R,
    };

    public class BlobInfo
    {
        public int Width;
        public int Height;
        public int Area;
        public Rectangle Rect = new Rectangle();
    }

    public class MorphologyExInfo
    {
        /// <summary>
        /// Mask 尺寸
        /// </summary>
        public int MaskSize = 3;
        /// <summary>
        /// Mask 模式
        /// </summary>
        public ElementShape MaskShape = ElementShape.Cross;
        /// <summary>
        /// 形態學處理模式
        /// </summary>
        public MorphOp Mode = MorphOp.Erode;
        /// <summary>
        /// 處理次數
        /// </summary>
        public int ExecTime = 0;

    }

    public class AOITool
    {
        //public int ImageWidth;
        //public int ImageHeight;
        private Mat MatImage = new Mat();
        private Rectangle ROI = new Rectangle();

        public CvBlobs blobs = new CvBlobs();

        private Mat MatGray;
        public Mat MatBinary;
        private Mat MatBinary2;

        public GrayFilter FilterMode = GrayFilter.Gray;
        public Byte ThresholdLow = 0;
        public Byte ThresholdHigh = 255;
        public List<BlobInfo> BlobList = new List<BlobInfo>();

        public List<MorphologyExInfo> MorphologyExList = new List<MorphologyExInfo>();

        public AOITool()
        {
            for (int i = 0; i<3; i++)
            {
                MorphologyExInfo ExInfo = new MorphologyExInfo();
                MorphologyExList.Add(ExInfo);
            }
        }

        public void SetImage(Mat image)
        {
            MatImage = image.Clone();
        }

        public void SetROI(Rectangle roi)
        {
            ROI = roi;

            MatBinary = new Mat(MatImage, ROI);
            MatBinary2 = new Mat(MatImage, ROI);
        }

        public Rectangle GetROI()
        {
            return ROI;
        }

        public Mat DoGray()
        {
            MatGray = new Mat(MatImage, ROI);
            Mat[] mat;
            switch (FilterMode)
            {
                case GrayFilter.Gray:
                    CvInvoke.CvtColor(MatGray, MatGray, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
                    break;

                case GrayFilter.B:
                    mat = MatGray.Split();
                    MatGray = mat[0];

                    break;

                case GrayFilter.G:
                    mat = MatGray.Split();
                    MatGray = mat[1];
                    break;

                case GrayFilter.R:
                    mat = MatGray.Split();
                    MatGray = mat[2];
                    break;
            }

            return MatGray;
        }

        public Mat DoBinary()
        {
            //轉灰階
            DoGray();

            //二值化
            CvInvoke.Threshold(MatGray, MatBinary, ThresholdLow, 255, ThresholdType.Binary);
            CvInvoke.Threshold(MatGray, MatBinary2, ThresholdHigh, 255, ThresholdType.BinaryInv);
            //MatBinary.ToImage<Gr,>

            Image<Gray, byte> img1 = MatBinary.ToImage<Gray, byte>();
            Image<Gray, byte> img2 = MatBinary2.ToImage<Gray, byte>();

            for(int y = 0; y < ROI.Height; y++)
            {
                for (int x = 0; x < ROI.Width; x++)
                {
                    if (img1.Data[y,x,0] == 0x00 || img2.Data[y, x, 0] == 0x00)
                    {
                        img1.Data[y, x, 0] = 0x00;

                        MatBinary = img1.Mat;
                    }
                }
            }

            return MatBinary;
        }

        public Mat MorphologyEx()
        {
            foreach(MorphologyExInfo exInfo in MorphologyExList)
            {
                if (exInfo.ExecTime == 0) continue;

                Mat structElement = CvInvoke.GetStructuringElement(exInfo.MaskShape,
                    new Size(exInfo.MaskSize, exInfo.MaskSize), new Point(-1, -1));

                CvInvoke.MorphologyEx(MatBinary, MatBinary, exInfo.Mode, structElement, new Point(-1, -1), exInfo.ExecTime,
                                     BorderType.Default, new MCvScalar(0, 0, 0));
            }

            return MatBinary;
        }

        public void BlobDetect()
        {

            BlobList.Clear();
            CvBlobs blobs = new CvBlobs();
            CvBlobDetector _blobDetector = new CvBlobDetector();
            _blobDetector.Detect(MatBinary.ToImage<Gray, byte>(), blobs);

            foreach (KeyValuePair<uint, CvBlob> item in blobs)
            {
                CvBlob b = item.Value;
                BlobInfo blobinfo = new BlobInfo
                {
                    Area = b.Area,
                    Width = b.BoundingBox.Right - b.BoundingBox.Left,
                    Height = b.BoundingBox.Bottom - b.BoundingBox.Top,
                };
            
                blobinfo.Rect.Location = new Point(ROI.Left + b.BoundingBox.Left, ROI.Top + b.BoundingBox.Top);
                blobinfo.Rect.Size = new Size(blobinfo.Width, blobinfo.Height);

                BlobList.Add(blobinfo);
            }

        }

        public bool Inspect()
        {
            bool result = true;

            DoBinary();
            MorphologyEx();
            BlobDetect();

            return result;
        }

    }
}
