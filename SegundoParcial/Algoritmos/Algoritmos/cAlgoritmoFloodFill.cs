using System.Collections.Generic;
using System.Drawing;

namespace Algoritmos
{
    internal class cAlgoritmoFloodFill
    {
        public static void FloodFill(Bitmap bmp, Point pt, Color colorRelleno)
        {
            Color colorObjetivo = bmp.GetPixel(pt.X, pt.Y);
            if (colorObjetivo.ToArgb() == colorRelleno.ToArgb()) return;

            Queue<Point> cola = new Queue<Point>();
            cola.Enqueue(pt);

            while (cola.Count > 0)
            {
                Point p = cola.Dequeue();
                if (p.X < 0 || p.X >= bmp.Width || p.Y < 0 || p.Y >= bmp.Height)
                    continue;
                if (bmp.GetPixel(p.X, p.Y) != colorObjetivo)
                    continue;

                bmp.SetPixel(p.X, p.Y, colorRelleno);

                cola.Enqueue(new Point(p.X + 1, p.Y));
                cola.Enqueue(new Point(p.X - 1, p.Y));
                cola.Enqueue(new Point(p.X, p.Y + 1));
                cola.Enqueue(new Point(p.X, p.Y - 1));
            }
        }
    }
}
