using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Algoritmos
{
    internal class cAlgoritmoFloodFill
    {
        // Dibuja y rellena un rombo centrado en (cx, cy) con tamaño dado
        public static void DibujarYRellenarRombo(Graphics mGraph, int cx, int cy)
        {
            int size = 50; // Tamaño del rombo
            Color colorBorde = Color.Black; // Color del borde del rombo
            Color colorRelleno = Color.LightBlue; // Color de relleno del rombo
            // 1. Crear un bitmap temporal
            int bmpSize = size * 2 + 10;
            Bitmap bmp = new Bitmap(bmpSize, bmpSize);

            // 2. Calcular los puntos del rombo
            Point[] rombo = new Point[]
            {
                new Point(cx, cy - size), // Arriba
                new Point(cx + size, cy), // Derecha
                new Point(cx, cy + size), // Abajo
                new Point(cx - size, cy)  // Izquierda
            };

            // 3. Dibujar el rombo en el bitmap
            using (Graphics gBmp = Graphics.FromImage(bmp))
            {
                gBmp.Clear(Color.White);
                gBmp.DrawPolygon(new Pen(colorBorde), rombo);
            }

            // 4. Dibujar el rombo en el Graphics recibido
            mGraph.DrawPolygon(new Pen(colorBorde), rombo);

            // 5. Aplicar FloodFill en el centro del rombo
            Point centro = new Point(cx, cy);
            FloodFill(bmp, centro, colorRelleno);

            // 6. Dibujar el resultado del bitmap en el Graphics recibido
            mGraph.DrawImage(bmp, 0, 0);
        }

        // FloodFill clásico sobre Bitmap
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

