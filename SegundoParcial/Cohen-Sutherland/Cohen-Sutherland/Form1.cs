using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cohen_Sutherland
{
    public partial class btnDraw : Form
    {
        cPicCanvasConfigure mPicCanvasConfig = new cPicCanvasConfigure();
        

        public btnDraw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            if (!float.TryParse(txtFirstPointX.Text, out float x1) ||
                !float.TryParse(txtFirstPointY.Text, out float y1) ||
                !float.TryParse(txtEndPointX.Text, out float x2) ||
                !float.TryParse(txtEndPointY.Text, out float y2))
            {
                MessageBox.Show("Please enter valid integer coordinates.");
                return;
            }

            x1 = float.Parse(txtFirstPointX.Text)*20f;
            y1 = float.Parse(txtFirstPointY.Text)*20f;
            x2 = float.Parse(txtEndPointX.Text) * 20f;
            y2 = float.Parse(txtEndPointY.Text) * 20f;

            cAlgoritmo mAlgoritmo = new cAlgoritmo(x1, y1, x2, y2);
            Graphics mGraph = mPicCanvasConfig.CanvaConfigure(picCanvas);
            mAlgoritmo.Dibujar(mGraph);

        }
    }
}
