using System;
using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos
{
    internal class cAlgoritmoBresenhamCircunferencia
    {
        private Point centro;
        private int radio;
        public List<Point> PixelesEncendidos { get; private set; }

        public cAlgoritmoBresenhamCircunferencia(Point centro, int radio)
        {
            this.centro = centro;
            this.radio = radio;
            PixelesEncendidos = new List<Point>();
        }

        public void DibujarCircunferencia(Graphics g, Brush brush, int delayMs = 0)
        {
            int x = 0, y = radio;
            int d = 3 - 2 * radio;
            while (y >= x)
            {
                DibujaSimetricos(g, brush, x, y);
                if (d < 0)
                    d = d + 4 * x + 6;
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
                if (delayMs > 0) System.Threading.Thread.Sleep(delayMs);
            }
        }

        private void DibujaSimetricos(Graphics g, Brush brush, int x, int y)
        {
            int cx = centro.X, cy = centro.Y;
            Point[] puntos = new Point[]
            {
                new Point(cx + x, cy + y), new Point(cx - x, cy + y),
                new Point(cx + x, cy - y), new Point(cx - x, cy - y),
                new Point(cx + y, cy + x), new Point(cx - y, cy + x),
                new Point(cx + y, cy - x), new Point(cx - y, cy - x)
            };
            foreach (var p in puntos)
            {
                g.FillRectangle(brush, p.X, p.Y, 1, 1);
                PixelesEncendidos.Add(p);
            }
        }
    }
}
