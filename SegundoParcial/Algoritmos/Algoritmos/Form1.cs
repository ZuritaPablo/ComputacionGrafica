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
            txtRadius.Visible = false;
        }

        // Animación de encendido de píxeles y listado
      

        // DDA con animación y listado
        private async void btnDraw_Click(object sender, EventArgs e)
        {
            if (cbxAlgotithms.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, selecciona algún algoritmo.");
                return;
            }
            // Cambia la comparación para usar el índice correcto (0 para DDA)
            if (cbxAlgotithms.SelectedIndex == 0)
            {
                picCanvas.Refresh();
                float x0, y0, x1, y1;
                if (!float.TryParse(txtStarPointX.Text, out x0) ||
                    !float.TryParse(txtStarPointY.Text, out y0) ||
                    !float.TryParse(txtFinishPointX.Text, out x1) ||
                    !float.TryParse(txtFinishPointY.Text, out y1))
                {
                    MessageBox.Show("Por favor, ingresa coordenadas válidas.");
                    return;
                }

                var puntoInicial = new PointF(x0, y0);
                var puntoFinal = new PointF(x1, y1);

                var algoritmoDDA = new cAlgoritmoDDA(puntoInicial, puntoFinal);
                Graphics mGraph = picCanvasConfig.CanvaConfigure(picCanvas);

                algoritmoDDA.DibujarLinea(mGraph);
            }
            if(cbxAlgotithms.SelectedIndex == 1)
            {
                picCanvas.Refresh();
                int x0, y0, x1, y1;
                if (!int.TryParse(txtStarPointX.Text, out x0) ||
                    !int.TryParse(txtStarPointY.Text, out y0) ||
                    !int.TryParse(txtFinishPointX.Text, out x1) ||
                    !int.TryParse(txtFinishPointY.Text, out y1))
                {
                    MessageBox.Show("Por favor, ingresa coordenadas válidas.");
                    return;
                }
                var puntoInicial = new Point(x0, y0);
                var puntoFinal = new Point(x1, y1);
                var algoritmoBresenham = new cAlgoritmoBresenhamLinea(puntoInicial, puntoFinal);
                Graphics mGraph = picCanvasConfig.CanvaConfigure(picCanvas);
                algoritmoBresenham.DibujarLinea(mGraph);
            }
            if (cbxAlgotithms.SelectedIndex ==2)
            {
                picCanvas.Refresh();
                int radius;
                Point centro=new Point(0,0);
                if (!int.TryParse(txtRadius.Text, out radius) || radius <= 0)
                {
                    MessageBox.Show("Por favor, ingresa un radio válido.");
                    return;
                }
                var algoritmoCirculo = new cAlgoritmoBresenhamCircunferencia(centro, radius);
                Graphics mGraph = picCanvasConfig.CanvaConfigure(picCanvas);
                algoritmoCirculo.DibujarCircunferencia(mGraph, 10); // 10 ms de delay entre píxeles
            }
            if (cbxAlgotithms.SelectedIndex == 3)
            {
                picCanvas.Refresh();
                Graphics mGraph = picCanvasConfig.CanvaConfigure(picCanvas);
                cAlgoritmoFloodFill.DibujarYRellenarRombo(mGraph, 0, 0);
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cbxAlgotithms_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxAlgotithms.SelectedIndex == 2)
            {
                txtRadius.Visible = true;
            }
            else
            {
                txtRadius.Visible = false;


            }
        }
    }
}
