using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    // Třída odpovídá za přepínání radio buttonu z Fyzické osoby na Firmu a změny viditelností panelů
    public static class RadioButtonChecking
    {
        public static void CheckedChange(
            RadioButton rbNaturalPerson,
            Panel panelNaturalPerson,
            Panel panelCompany,
            TextBox nameCompanyBox,
            TextBox companyIdBox,
            TextBox emailCompanyBox,
            TextBox namePersonBox,
            TextBox surnameBox,
            TextBox emailPersonBox,
            TextBox phoneNumberCompanyBox,
            TextBox phoneNumberPersonBox)
        {
            // Přepínání viditelnosti panelů podle stavu RadioButtonu
            if (rbNaturalPerson.Checked)
            {
                panelNaturalPerson.Visible = true;
                panelCompany.Visible = false;
                nameCompanyBox.Text = "";
                companyIdBox.Text = "";
                emailCompanyBox.Text = "";
                phoneNumberCompanyBox.Text = PhonePlaceholder.placeholderValue;
                phoneNumberCompanyBox.ForeColor = Color.Gray;
            }
            else
            {
                rbNaturalPerson.Checked = false;
                panelNaturalPerson.Visible = false;
                panelCompany.Visible = true;
                namePersonBox.Text = "";
                surnameBox.Text = "";
                emailPersonBox.Text = "";
                phoneNumberPersonBox.Text = PhonePlaceholder.placeholderValue;
                phoneNumberPersonBox.ForeColor = Color.Gray;
            }
        }
    }
}
