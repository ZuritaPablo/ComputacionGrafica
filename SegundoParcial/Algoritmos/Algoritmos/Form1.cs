using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class Form1 : Form
    {
        cPicCanvasConfig picCanvasConfig = new cPicCanvasConfig();

        public Form1()
        {
            InitializeComponent();
        }

        // Animaci�n de encendido de p�xeles y listado
      

        // DDA con animaci�n y listado
        private async void btnDraw_Click(object sender, EventArgs e)
        {
            picCanvas.Refresh();
            float x0, y0, x1, y1;
            if (!float.TryParse(txtStarPointX.Text, out x0) ||
                !float.TryParse(txtStarPointY.Text, out y0) ||
                !float.TryParse(txtFinishPointX.Text, out x1) ||
                !float.TryParse(txtFinishPointY.Text, out y1))
            {
                MessageBox.Show("Por favor, ingresa coordenadas v�lidas.");
                return;
            }

            var puntoInicial = new PointF(x0, y0);
            var puntoFinal = new PointF(x1, y1);

            var algoritmoDDA = new cAlgoritmoDDA(puntoInicial, puntoFinal);
            Graphics mGraph = picCanvasConfig.CanvaConfigure(picCanvas);


            algoritmoDDA.DibujarLinea(mGraph);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
