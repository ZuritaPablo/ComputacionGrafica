using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos
{
    internal class cAlgoritmoBresenhamLinea
    {
        private Point puntoInicial;
        private Point puntoFinal;
        public List<Point> PixelesEncendidos { get; private set; }

        public cAlgoritmoBresenhamLinea(Point puntoInicial, Point puntoFinal)
        {
            this.puntoInicial = puntoInicial;
            this.puntoFinal = puntoFinal;
            PixelesEncendidos = new List<Point>();
        }

        public void DibujarLinea(Graphics g, int delayMs = 0)
        {
            Brush brush = new SolidBrush(Color.Blue);
            int x0 = puntoInicial.X, y0 = puntoInicial.Y;
            int x1 = puntoFinal.X, y1 = puntoFinal.Y;
            int dx = Math.Abs(x1 - x0), dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                g.FillRectangle(brush, x0, y0, 1, 1);
                PixelesEncendidos.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                int e2 = 2 * err;
                if (e2 > -dy) { err -= dy; x0 += sx; }
                if (e2 < dx) { err += dx; y0 += sy; }
                if (delayMs > 0) System.Threading.Thread.Sleep(delayMs);
            }
        }
    }
}
