using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();

            // Zaoblení pomocí třídy Rounded
            this.Region = Rounded.WindowRounding(this, 50);

            // Výchozí zobrazení informací a komponentů ve WelcomeWindow
            RbNaturalPerson.Checked = true;
            PanelNaturalPerson.Visible = true;
            PanelCompany.Visible = false;

            // Placeholder pro telefonní číslo
            PhonePlaceholder.ApplyPlaceholder(PhoneNumberCompanyBox);
            PhonePlaceholder.ApplyPlaceholder(PhoneNumberPersonBox);


            // Zamezení zadávání jiných znaků než čísel v TextBoxu Tel.číslo a IČO
            PhoneNumberPersonBox.KeyPress += Validator.OnlyDigits;
            PhoneNumberCompanyBox.KeyPress += Validator.OnlyDigits;
            CompanyIdBox.KeyPress += Validator.OnlyDigits;

            // Připojení událostí k WelcomeWindow pro pohyb okna
            this.MouseDown += new MouseEventHandler(WindowMover.MouseDown);
            this.MouseMove += new MouseEventHandler((sender, e) => WindowMover.MouseMove(this, e));
            // Připojení událostí pro pohyb okna k panelu Firma
            PanelCompany.MouseDown += new MouseEventHandler(WindowMover.MouseDown);
            PanelCompany.MouseMove += new MouseEventHandler((sender, e) => WindowMover.MouseMove(this, e));
            // Připojení událostí pro pohyb okna k panelu Fyzická osoba
            PanelNaturalPerson.MouseDown += new MouseEventHandler(WindowMover.MouseDown);
            PanelNaturalPerson.MouseMove += new MouseEventHandler((sender, e) => WindowMover.MouseMove(this, e));
        }

        // Zavření okna tlačítkem "x"
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Přepínání Radio buttonu z Fyzické osoby na Firmu
        private void RbNaturalPerson_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonChecking.CheckedChange(
                RbNaturalPerson,
                PanelNaturalPerson,
                PanelCompany,
                NameCompanyBox,
                CompanyIdBox,
                EmailCompanyBox,
                NamePersonBox,
                SurnameBox,
                EmailPersonBox,
                PhoneNumberCompanyBox,
                PhoneNumberPersonBox);
        }

        // Kontroluje, zda jsou všechny TextBoxy vyplněné ve správném formátu nebo nejsou prázdné
        private void AddButton_Click(object sender, EventArgs e)
        {
            Validator.Validation(PhoneNumberPersonBox.Text,
                                 PhoneNumberCompanyBox.Text,
                                 RbNaturalPerson,
                                 RbCompany,
                                 EmailPersonBox.Text,
                                 EmailCompanyBox.Text,
                                 NamePersonBox.Text,
                                 SurnameBox.Text,
                                 NameCompanyBox.Text,
                                 CompanyIdBox.Text);
        }
    }
}
