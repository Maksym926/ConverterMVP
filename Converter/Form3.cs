﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase1;

namespace Converter
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            RegisterPasswordTextBox.PasswordChar = '*';
            ConfirmPasswordTextBox.PasswordChar = '*';

        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (DataBase1.ApplicationContext db = new DataBase1.ApplicationContext())
            {

                errorProviderName.Clear();
                errorProviderPassword.Clear();
                bool IsCorrect = true;
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    if (RegisterNameTextBox.Text == u.UserName)
                    {
                        errorProviderName.SetError(RegisterNameTextBox, "Existing login");
                        MessageBox.Show("This login is already exists");
                        IsCorrect = false;
                        break;
                    }
                }
                if (string.IsNullOrEmpty(RegisterNameTextBox.Text))
                {
                    errorProviderName.SetError(RegisterNameTextBox, "Required");
                    IsCorrect = false;
                }
                if (string.IsNullOrEmpty(RegisterPasswordTextBox.Text))
                {
                    errorProviderPassword.SetError(RegisterPasswordTextBox, "Required");
                    IsCorrect = false;
                }
                if (RegisterPasswordTextBox.Text != ConfirmPasswordTextBox.Text)
                {
                    errorProviderName.SetError(ConfirmPasswordTextBox, "Passwards do not match");
                    MessageBox.Show("Passwards do not match");
                    IsCorrect = false;
                }


                if (IsCorrect)
                {

                    User user = new User { UserName = RegisterNameTextBox.Text, Password = EncryptString(ToSecureString(RegisterPasswordTextBox.Text)), output = "" };

                    db.Users.Add(user);
                    db.SaveChanges();
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.Show();


                }

            }
        }
        #region Encrypte password
        static byte[] entropy = Encoding.Unicode.GetBytes("SaLtY bOy 6970 ePiC");
        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }
        public static string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(input)), entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }
        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }
        #endregion



        private void Form3_Load(object sender, EventArgs e)
        {

        }


        private void ShowPasswordcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordcheckBox2.Checked)
            {
                ConfirmPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                ConfirmPasswordTextBox.PasswordChar = '*';
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                RegisterPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                RegisterPasswordTextBox.PasswordChar = '*';
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
