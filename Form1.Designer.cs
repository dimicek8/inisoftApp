namespace InisoftApp
{
    partial class WelcomeWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.CloseButton = new System.Windows.Forms.Button();
            this.RbNaturalPerson = new System.Windows.Forms.RadioButton();
            this.RbCompany = new System.Windows.Forms.RadioButton();
            this.PanelNaturalPerson = new System.Windows.Forms.Panel();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.EmailPersonBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberPersonBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthday = new System.Windows.Forms.Label();
            this.UserNames = new System.Windows.Forms.Label();
            this.DateOfBirthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.Surname = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NamePersonBox = new System.Windows.Forms.TextBox();
            this.PanelCompany = new System.Windows.Forms.Panel();
            this.PhoneNumberCompany = new System.Windows.Forms.Label();
            this.EmailCompany = new System.Windows.Forms.Label();
            this.EmailCompanyBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberCompanyBox = new System.Windows.Forms.TextBox();
            this.NameCompany = new System.Windows.Forms.Label();
            this.CompanyId = new System.Windows.Forms.Label();
            this.CompanyIdBox = new System.Windows.Forms.TextBox();
            this.NameCompanyBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PanelNaturalPerson.SuspendLayout();
            this.PanelCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.Location = new System.Drawing.Point(683, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(31, 27);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "x";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RbNaturalPerson
            // 
            this.RbNaturalPerson.AutoSize = true;
            this.RbNaturalPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RbNaturalPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RbNaturalPerson.ForeColor = System.Drawing.Color.White;
            this.RbNaturalPerson.Location = new System.Drawing.Point(149, 59);
            this.RbNaturalPerson.Name = "RbNaturalPerson";
            this.RbNaturalPerson.Size = new System.Drawing.Size(126, 20);
            this.RbNaturalPerson.TabIndex = 1;
            this.RbNaturalPerson.TabStop = true;
            this.RbNaturalPerson.Text = "Fyzická osoba";
            this.RbNaturalPerson.UseVisualStyleBackColor = true;
            this.RbNaturalPerson.CheckedChanged += new System.EventHandler(this.RbNaturalPerson_CheckedChanged);
            // 
            // RbCompany
            // 
            this.RbCompany.AutoSize = true;
            this.RbCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RbCompany.ForeColor = System.Drawing.Color.White;
            this.RbCompany.Location = new System.Drawing.Point(482, 59);
            this.RbCompany.Name = "RbCompany";
            this.RbCompany.Size = new System.Drawing.Size(64, 20);
            this.RbCompany.TabIndex = 2;
            this.RbCompany.TabStop = true;
            this.RbCompany.Text = "Firma";
            this.RbCompany.UseVisualStyleBackColor = true;
            // 
            // PanelNaturalPerson
            // 
            this.PanelNaturalPerson.Controls.Add(this.PhoneNumber);
            this.PanelNaturalPerson.Controls.Add(this.Email);
            this.PanelNaturalPerson.Controls.Add(this.EmailPersonBox);
            this.PanelNaturalPerson.Controls.Add(this.PhoneNumberPersonBox);
            this.PanelNaturalPerson.Controls.Add(this.DateOfBirthday);
            this.PanelNaturalPerson.Controls.Add(this.UserNames);
            this.PanelNaturalPerson.Controls.Add(this.DateOfBirthdayPicker);
            this.PanelNaturalPerson.Controls.Add(this.Surname);
            this.PanelNaturalPerson.Controls.Add(this.SurnameBox);
            this.PanelNaturalPerson.Controls.Add(this.NamePersonBox);
            this.PanelNaturalPerson.Location = new System.Drawing.Point(73, 126);
            this.PanelNaturalPerson.Name = "PanelNaturalPerson";
            this.PanelNaturalPerson.Size = new System.Drawing.Size(567, 188);
            this.PanelNaturalPerson.TabIndex = 3;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumber.ForeColor = System.Drawing.Color.White;
            this.PhoneNumber.Location = new System.Drawing.Point(12, 147);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(84, 20);
            this.PhoneNumber.TabIndex = 10;
            this.PhoneNumber.Text = "Tel. číslo:";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Email.ForeColor = System.Drawing.Color.White;
            this.Email.Location = new System.Drawing.Point(314, 147);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(58, 20);
            this.Email.TabIndex = 9;
            this.Email.Text = "Email:";
            // 
            // EmailPersonBox
            // 
            this.EmailPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailPersonBox.Location = new System.Drawing.Point(378, 147);
            this.EmailPersonBox.Multiline = true;
            this.EmailPersonBox.Name = "EmailPersonBox";
            this.EmailPersonBox.Size = new System.Drawing.Size(134, 26);
            this.EmailPersonBox.TabIndex = 8;
            // 
            // PhoneNumberPersonBox
            // 
            this.PhoneNumberPersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberPersonBox.Location = new System.Drawing.Point(100, 147);
            this.PhoneNumberPersonBox.MaxLength = 9;
            this.PhoneNumberPersonBox.Multiline = true;
            this.PhoneNumberPersonBox.Name = "PhoneNumberPersonBox";
            this.PhoneNumberPersonBox.Size = new System.Drawing.Size(119, 26);
            this.PhoneNumberPersonBox.TabIndex = 7;
            // 
            // DateOfBirthday
            // 
            this.DateOfBirthday.AutoSize = true;
            this.DateOfBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfBirthday.ForeColor = System.Drawing.Color.White;
            this.DateOfBirthday.Location = new System.Drawing.Point(229, 93);
            this.DateOfBirthday.Name = "DateOfBirthday";
            this.DateOfBirthday.Size = new System.Drawing.Size(141, 20);
            this.DateOfBirthday.TabIndex = 6;
            this.DateOfBirthday.Text = "Datum narození:";
            // 
            // UserNames
            // 
            this.UserNames.AutoSize = true;
            this.UserNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UserNames.ForeColor = System.Drawing.Color.White;
            this.UserNames.Location = new System.Drawing.Point(12, 36);
            this.UserNames.Name = "UserNames";
            this.UserNames.Size = new System.Drawing.Size(67, 20);
            this.UserNames.TabIndex = 5;
            this.UserNames.Text = "Jméno:";
            // 
            // DateOfBirthdayPicker
            // 
            this.DateOfBirthdayPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateOfBirthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthdayPicker.Location = new System.Drawing.Point(378, 93);
            this.DateOfBirthdayPicker.Name = "DateOfBirthdayPicker";
            this.DateOfBirthdayPicker.Size = new System.Drawing.Size(134, 26);
            this.DateOfBirthdayPicker.TabIndex = 4;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Surname.ForeColor = System.Drawing.Color.White;
            this.Surname.Location = new System.Drawing.Point(295, 33);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(77, 20);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Příjmení:";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SurnameBox.Location = new System.Drawing.Point(378, 33);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(134, 26);
            this.SurnameBox.TabIndex = 2;
            // 
            // NamePersonBox
            // 
            this.NamePersonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NamePersonBox.Location = new System.Drawing.Point(85, 36);
            this.NamePersonBox.Multiline = true;
            this.NamePersonBox.Name = "NamePersonBox";
            this.NamePersonBox.Size = new System.Drawing.Size(134, 26);
            this.NamePersonBox.TabIndex = 0;
            // 
            // PanelCompany
            // 
            this.PanelCompany.Controls.Add(this.PhoneNumberCompany);
            this.PanelCompany.Controls.Add(this.EmailCompany);
            this.PanelCompany.Controls.Add(this.EmailCompanyBox);
            this.PanelCompany.Controls.Add(this.PhoneNumberCompanyBox);
            this.PanelCompany.Controls.Add(this.NameCompany);
            this.PanelCompany.Controls.Add(this.CompanyId);
            this.PanelCompany.Controls.Add(this.CompanyIdBox);
            this.PanelCompany.Controls.Add(this.NameCompanyBox);
            this.PanelCompany.Location = new System.Drawing.Point(73, 126);
            this.PanelCompany.Name = "PanelCompany";
            this.PanelCompany.Size = new System.Drawing.Size(567, 188);
            this.PanelCompany.TabIndex = 11;
            // 
            // PhoneNumberCompany
            // 
            this.PhoneNumberCompany.AutoSize = true;
            this.PhoneNumberCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberCompany.ForeColor = System.Drawing.Color.White;
            this.PhoneNumberCompany.Location = new System.Drawing.Point(27, 114);
            this.PhoneNumberCompany.Name = "PhoneNumberCompany";
            this.PhoneNumberCompany.Size = new System.Drawing.Size(84, 20);
            this.PhoneNumberCompany.TabIndex = 10;
            this.PhoneNumberCompany.Text = "Tel. číslo:";
            // 
            // EmailCompany
            // 
            this.EmailCompany.AutoSize = true;
            this.EmailCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailCompany.ForeColor = System.Drawing.Color.White;
            this.EmailCompany.Location = new System.Drawing.Point(314, 111);
            this.EmailCompany.Name = "EmailCompany";
            this.EmailCompany.Size = new System.Drawing.Size(58, 20);
            this.EmailCompany.TabIndex = 9;
            this.EmailCompany.Text = "Email:";
            // 
            // EmailCompanyBox
            // 
            this.EmailCompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailCompanyBox.Location = new System.Drawing.Point(378, 111);
            this.EmailCompanyBox.MaxLength = 20;
            this.EmailCompanyBox.Multiline = true;
            this.EmailCompanyBox.Name = "EmailCompanyBox";
            this.EmailCompanyBox.Size = new System.Drawing.Size(134, 26);
            this.EmailCompanyBox.TabIndex = 8;
            // 
            // PhoneNumberCompanyBox
            // 
            this.PhoneNumberCompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PhoneNumberCompanyBox.Location = new System.Drawing.Point(115, 114);
            this.PhoneNumberCompanyBox.MaxLength = 9;
            this.PhoneNumberCompanyBox.Multiline = true;
            this.PhoneNumberCompanyBox.Name = "PhoneNumberCompanyBox";
            this.PhoneNumberCompanyBox.Size = new System.Drawing.Size(119, 26);
            this.PhoneNumberCompanyBox.TabIndex = 7;
            // 
            // NameCompany
            // 
            this.NameCompany.AutoSize = true;
            this.NameCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameCompany.ForeColor = System.Drawing.Color.White;
            this.NameCompany.Location = new System.Drawing.Point(31, 42);
            this.NameCompany.Name = "NameCompany";
            this.NameCompany.Size = new System.Drawing.Size(63, 20);
            this.NameCompany.TabIndex = 5;
            this.NameCompany.Text = "Název:";
            // 
            // CompanyId
            // 
            this.CompanyId.AutoSize = true;
            this.CompanyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompanyId.ForeColor = System.Drawing.Color.White;
            this.CompanyId.Location = new System.Drawing.Point(327, 39);
            this.CompanyId.Name = "CompanyId";
            this.CompanyId.Size = new System.Drawing.Size(45, 20);
            this.CompanyId.TabIndex = 3;
            this.CompanyId.Text = "IČO:";
            // 
            // CompanyIdBox
            // 
            this.CompanyIdBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CompanyIdBox.Location = new System.Drawing.Point(378, 36);
            this.CompanyIdBox.MaxLength = 8;
            this.CompanyIdBox.Multiline = true;
            this.CompanyIdBox.Name = "CompanyIdBox";
            this.CompanyIdBox.Size = new System.Drawing.Size(134, 26);
            this.CompanyIdBox.TabIndex = 2;
            // 
            // NameCompanyBox
            // 
            this.NameCompanyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameCompanyBox.Location = new System.Drawing.Point(100, 39);
            this.NameCompanyBox.Multiline = true;
            this.NameCompanyBox.Name = "NameCompanyBox";
            this.NameCompanyBox.Size = new System.Drawing.Size(134, 26);
            this.NameCompanyBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.WindowText;
            this.AddButton.Location = new System.Drawing.Point(315, 349);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 38);
            this.AddButton.TabIndex = 12;
            this.AddButton.Text = "Přidat";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // WelcomeWindow
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(70)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(726, 431);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RbCompany);
            this.Controls.Add(this.RbNaturalPerson);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.PanelCompany);
            this.Controls.Add(this.PanelNaturalPerson);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WelcomeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InisoftApp";
            this.PanelNaturalPerson.ResumeLayout(false);
            this.PanelNaturalPerson.PerformLayout();
            this.PanelCompany.ResumeLayout(false);
            this.PanelCompany.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.RadioButton RbNaturalPerson;
        private System.Windows.Forms.RadioButton RbCompany;
        private System.Windows.Forms.Panel PanelNaturalPerson;
        private System.Windows.Forms.TextBox NamePersonBox;
        
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthdayPicker;
        private System.Windows.Forms.Label UserNames;
        private System.Windows.Forms.Label DateOfBirthday;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.TextBox EmailPersonBox;
        private System.Windows.Forms.TextBox PhoneNumberPersonBox;
        private System.Windows.Forms.Panel PanelCompany;
        private System.Windows.Forms.Label PhoneNumberCompany;
        private System.Windows.Forms.Label EmailCompany;
        private System.Windows.Forms.TextBox EmailCompanyBox;
        private System.Windows.Forms.TextBox PhoneNumberCompanyBox;
        private System.Windows.Forms.Label NameCompany;
        private System.Windows.Forms.Label CompanyId;
        private System.Windows.Forms.TextBox CompanyIdBox;
        private System.Windows.Forms.TextBox NameCompanyBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label PhoneNumber;
    }
}

