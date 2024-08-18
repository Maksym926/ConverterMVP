using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase1;
using Manager;
using Microsoft.Data.SqlClient;

namespace Converter
{
    public partial class Form2 : Form
    {
        public static Form2 instanse;
        public Form2()
        {
            InitializeComponent();
            instanse = this;
            PasswordtextBox.PasswordChar = '*';
            
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public TextBox tb1;
        public TextBox tb2;

        private void loginButton_Click(object sender, EventArgs e)
        {
           /* bool IsFound = false;
            tb1 = UserNameTextBox;
            tb2 = PasswordtextBox;
            errorProviderUserName.Clear();
            errorProviderPassword.Clear();*/

            /*User user = new User();
            using (DataBase1.ApplicationContext db = new DataBase1.ApplicationContext())
            {
                
                var users = db.Users.ToList();
                bool IsCorrect = true;
                foreach (DataBase1.User u in users)
                {
                    if (string.IsNullOrEmpty(UserNameTextBox.Text)) {
                        errorProviderUserName.SetError(UserNameTextBox, "Required");
                        IsCorrect = false;
                    }
                    if (string.IsNullOrEmpty(PasswordtextBox.Text)) {
                        errorProviderPassword.SetError(PasswordtextBox, "Required");
                        IsCorrect = false;
                    }

                    string decriptedStr = ToInsecureString(DecryptString(u.Password));
                    if (IsCorrect) {
                        if (UserNameTextBox.Text == u.Name && PasswordtextBox.Text == decriptedStr)
                        {
                            IsFound = true;
                            Form1 winForm = new Form1();
                            Model model = new Model();
                            Presenter presenter = new Presenter(model, winForm);
                            this.Hide();

                            winForm.Show();
                            break;
                        }
                        
                    }                  
                }
                if (!IsFound) {
                    MessageBox.Show("Login or password is incorect");
                }


            }*/
            string connectionString = "Server=WIN-S3MBIL1NUK7\\sqlexpress;Database=User;User ID=sa;Password=Maxakin_max; Encrypt=false;";
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            string sqlExpression = "Select Name, Password From UserInfo ";
            SqlCommand cmd  = new SqlCommand(sqlExpression, conn);

            SqlDataReader reader = cmd.ExecuteReader();
            bool IsFound = false;
            bool IsCorrect = true;
            tb1 = UserNameTextBox;
            tb2 = PasswordtextBox;
            errorProviderUserName.Clear();
            errorProviderPassword.Clear();
            while (reader.Read()) {
                if (string.IsNullOrEmpty(UserNameTextBox.Text))
                {
                    errorProviderUserName.SetError(UserNameTextBox, "Required");
                    IsCorrect = false;
                }
                if (string.IsNullOrEmpty(PasswordtextBox.Text))
                {
                    errorProviderPassword.SetError(PasswordtextBox, "Required");
                    IsCorrect = false;
                }

                /*string decriptedStr = ToInsecureString(DecryptString(reader["Password"].ToString()));*/
                if (IsCorrect)
                {
                    if (UserNameTextBox.Text == reader["Name"].ToString() && PasswordtextBox.Text == ToInsecureString(DecryptString(reader["Password"].ToString())))
                    {
                        IsFound = true;
                        Form1 winForm = new Form1();
                        Model model = new Model();
                        Presenter presenter = new Presenter(model, winForm);
                        this.Hide();

                        winForm.Show();
                        break;
                    }

                }
            }
            if (!IsFound)
            {
                MessageBox.Show("Login or password is incorect");
            }

        }
        

        private void RegButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
        #region decrypte password
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

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
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
        
    }
}
