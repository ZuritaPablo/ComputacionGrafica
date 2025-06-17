using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cohen_Sutherland
{
    internal class cPicCanvasConfigure
    {
        private Graphics mGraph;

        //Construcor sin parámetros
        public cPicCanvasConfigure()
        {
            mGraph = null;
        }


        public Graphics CanvaConfigure(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mGraph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            mGraph.Clear(Color.White);
            return mGraph;
        }
    }
 }


