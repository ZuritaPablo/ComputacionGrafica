using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    internal class cAlgoritmoDDA
    {
        private PointF puntoInicial;
        private PointF puntoFinal;

        public cAlgoritmoDDA(PointF puntoInicial, PointF puntoFinal)
        {
            this.puntoInicial = puntoInicial;
            this.puntoFinal = puntoFinal;
        }
        public void DibujarLinea(Graphics mGraph)
        {
            
            float deltaX = puntoFinal.X - puntoInicial.X;
            float deltaY = puntoFinal.Y - puntoInicial.Y;
            float pendiente = deltaY / deltaX;

            PointF puntoActual = new PointF(puntoInicial.X, puntoInicial.Y);

            float k;
            if (deltaX > deltaY)
            {
                k = deltaX;
            }
            else
            {
                k = deltaY;
            }
            float n = 1f;
            Brush brush = new SolidBrush(Color.Black);
            for (int i = 0; i <= k; i++)
            {
                if (pendiente <= 1)
                {
                    puntoActual.X += 1;
                    puntoActual.Y += pendiente;
                   
                    mGraph.FillRectangle(brush,(int)Math.Round(puntoActual.X),-(int)Math.Round(puntoActual.Y), n, n);
                }
                else if (pendiente > 1)
                {
                    puntoActual.X += (1 / pendiente);
                    puntoActual.Y += 1;
                    mGraph.FillRectangle(brush, (int)Math.Round(puntoActual.X), -(int)Math.Round(puntoActual.Y), n, n);
                }

            }
        }


    }
}
