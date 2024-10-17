using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    // Třída pro placeholder pro TextBox s telefonním číslem
    public static class PhonePlaceholder
    {
        public static string placeholderValue = "723456789";

        // Nastaví placeholder, když je pole práždné
        public static void SetPlaceholder(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = placeholderValue;
                textBox.ForeColor = Color.Gray;
            }
        }

        // Vymaže placeholder, když uživatel klikne do pole
        public static void RemovePlaceholder(TextBox textBox)
        {
            if (textBox.Text == placeholderValue)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        // Nastaví výchozí placeholder a barvu textu při spuštění aplikace
        public static void ApplyPlaceholder(TextBox textBox)
        {
            textBox.Text = placeholderValue;
            textBox.ForeColor = Color.Gray;

            // Připojí metody pro zobrazení a odstranění placeholderu k událostem Leave a Enter
            textBox.Leave += (sender, e) => SetPlaceholder(textBox);
            textBox.Enter += (sender, e) => RemovePlaceholder(textBox);
        }
    }
}
