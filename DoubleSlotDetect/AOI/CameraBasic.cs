using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;

namespace DoubleSlotDetect
{
    public class CameraBasic
    {
        public VideoCapture Cap;
        public Mat MatFrame;

        public AOITool Tool;

        public bool IsLive = false;
    }
}
