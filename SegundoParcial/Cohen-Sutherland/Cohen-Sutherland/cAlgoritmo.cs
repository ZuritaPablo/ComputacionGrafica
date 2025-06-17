using System;
using System.Drawing;

namespace Cohen_Sutherland
{
    internal class cAlgoritmo
    {
        public float x1, y1, x2, y2;

        // Ventana de recorte (centrada en el origen)
        public float xmin = -100, ymin = -50, xmax = 100, ymax = 50;

        // Códigos de región
        const int INSIDE = 0;
        const int LEFT = 1;
        const int RIGHT = 2;
        const int BOTTOM = 4;
        const int TOP = 8;

        public cAlgoritmo(float x1, float y1, float x2, float y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        private int ComputeCode(float x, float y)
        {
            int code = INSIDE;

            if (x < xmin) code |= LEFT;
            else if (x > xmax) code |= RIGHT;

            if (y < ymin) code |= BOTTOM;
            else if (y > ymax) code |= TOP;

            return code;
        }

        public void Dibujar(Graphics mGraph)
        {
            var state = mGraph.Save();

            // Transformar origen al centro y eje Y invertido
            mGraph.TranslateTransform(mGraph.VisibleClipBounds.Width / 2, mGraph.VisibleClipBounds.Height / 2);
            mGraph.ScaleTransform(1, -1);

            // Dibujar rectángulo azul
            mGraph.DrawRectangle(Pens.Blue, xmin, ymin, xmax - xmin, ymax - ymin);

            // Dibujar línea original en negro
            mGraph.DrawLine(Pens.Black, x1, y1, x2, y2);

            // Variables locales para recorte
            float cx1 = x1, cy1 = y1, cx2 = x2, cy2 = y2;
            int code1 = ComputeCode(cx1, cy1);
            int code2 = ComputeCode(cx2, cy2);
            bool accept = false;

            while (true)
            {
                if ((code1 | code2) == 0)
                {
                    accept = true;
                    break;
                }
                else if ((code1 & code2) != 0)
                {
                    break;
                }
                else
                {
                    int codeOut = (code1 != 0) ? code1 : code2;
                    float x = 0, y = 0;

                    if ((codeOut & TOP) != 0)
                    {
                        x = cx1 + (cx2 - cx1) * (ymax - cy1) / (cy2 - cy1);
                        y = ymax;
                    }
                    else if ((codeOut & BOTTOM) != 0)
                    {
                        x = cx1 + (cx2 - cx1) * (ymin - cy1) / (cy2 - cy1);
                        y = ymin;
                    }
                    else if ((codeOut & RIGHT) != 0)
                    {
                        y = cy1 + (cy2 - cy1) * (xmax - cx1) / (cx2 - cx1);
                        x = xmax;
                    }
                    else if ((codeOut & LEFT) != 0)
                    {
                        y = cy1 + (cy2 - cy1) * (xmin - cx1) / (cx2 - cx1);
                        x = xmin;
                    }

                    if (codeOut == code1)
                    {
                        cx1 = x;
                        cy1 = y;
                        code1 = ComputeCode(cx1, cy1);
                    }
                    else
                    {
                        cx2 = x;
                        cy2 = y;
                        code2 = ComputeCode(cx2, cy2);
                    }
                }
            }

            if (accept)
            {
                // Dibujar la línea recortada en rojo
                mGraph.DrawLine(Pens.Red, cx1, cy1, cx2, cy2);
            }

            mGraph.Restore(state);
        }
    }
}
