using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    // Třída zajišťující pohyb okna pomocí kurzoru
    public static class WindowMover
    {
        private static Point lastPoint;

        // Funkce pro uchování pozice při stisknutí myši
        public static void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPoint = new Point(e.X, e.Y);
            }
        }

        // Funkce pro přesun okna podle pohybu myši
        public static void MouseMove(Form form, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                form.Left += e.X - lastPoint.X;
                form.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
