using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    internal class cPicCanvasConfig
    {
        private Graphics mGraph;

        //Construcor sin parámetros
        public cPicCanvasConfig()
        {
            mGraph = null;
        }


        public Graphics CanvaConfigure(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();

            int centerX = picCanvas.Width / 2;
            int centerY = picCanvas.Height / 2;
            mGraph.TranslateTransform(centerX, centerY);
            float angle = 0;

            float zoomFactor = 10.0f;
            mGraph.ScaleTransform(zoomFactor, zoomFactor);
            



            mGraph.RotateTransform(angle);
            return mGraph;
        }
    }
}
