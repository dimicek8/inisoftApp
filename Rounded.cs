using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    // Třída pro zaoblení rohů WelcomeWindow
    public static class Rounded
    {
        // Import Windows API funkce pro zaoblení rohů
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        // Metoda pro vytvoření efektu zaoblení
        public static Region WindowRounding(Control control, int radius)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius);
            return Region.FromHrgn(ptr);
        }
    }
}
