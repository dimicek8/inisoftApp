using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InisoftApp
{
    // Třída, která kontroluje, zada jsou TextBoxy vyplněné ve správném formátu a nejsou prázdné
    public static class Validator
    {
        // Funkce kontroluje, že zadaný znak je buď číslice nebo řídicí znak
        public static void OnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        // Kotnroluje formáty telefonních čísel a emailů a zda jsou vyplněné i TextBoxy Jméno a Příjmení
        public static void Validation(string phoneNumberPerson,
                                      string phoneNumberCompany,
                                      RadioButton rbNaturalPerson,
                                      RadioButton rbCompany,
                                      string emailPerson, 
                                      string emailCompany, 
                                      string nameBox,
                                      string surnameBox,
                                      string nameCompanyBox,
                                      string companyIdBox)
        {
            // Kontroluje počet znaků v telefonním čísle
            bool PhoneNumberValidation(string phoneNumber)
            {
                return phoneNumber.Length == 9 &&
                       phoneNumber != PhonePlaceholder.placeholderValue;
            }
            // Kontroluje formát emailu
            bool EmailValidation(string email)
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                return Regex.IsMatch(email, emailPattern);
            }
            // Kontroluje počet znaků v IČO
            bool CompanyIdValidation(string companyId)
            {
                return companyId.Length == 8;
            }


            // Kontroluje, zda jsou vyplněné TextBoxy Jméno a Příjmení
            if ((nameBox == "" || surnameBox == "") && rbNaturalPerson.Checked)
            {
                MessageBox.Show("Zadejte Jméno a Příjmení");
                return;
            }
            // Kontroluje, zda uživatel zadal název firmy
            if (nameCompanyBox == "" && rbCompany.Checked)
            {
                MessageBox.Show("Zadejte Název firmy");
                return;
            }
            // Upozorňuje uživatele na chybu v IČO
            if (!CompanyIdValidation(companyIdBox) && rbCompany.Checked)
            {
                MessageBox.Show("Nesprávný formát IČO");
                return;
            }
            // Upozorňuje uživatel na chybu v telefonním čísle
            if (!PhoneNumberValidation(phoneNumberPerson) && !PhoneNumberValidation(phoneNumberCompany))
            {
                MessageBox.Show("Neplatné Telefonní číslo");
                return;
            }
            // Upozorňuje uživatele na chybu v emailu
            if (!EmailValidation(emailPerson) && !EmailValidation(emailCompany))
            {
                MessageBox.Show("Neplatný Email");
                return;
            }


            MessageBox.Show("Údaje byly úspěšně přidány do databáze");
        }
    }
}
