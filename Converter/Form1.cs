/*using DataBase1;*/   
using Manager;
using Microsoft.VisualBasic.Logging;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security;
using System.Text;
using myDB;
using System.Data;
using Microsoft.Data.SqlClient;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;



namespace Converter
{
    public partial class Form1 : Form, IView
    {
        

    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            
        }
        public string result = "";

        public string Item1 { get => Input.Text; }
        public string Item2 { get => OutPut.Text; }

        public string num { get => number.Text; }

        private Presenter presenter;
        public void SetPresenter(Presenter presenter)
        {
            this.presenter = presenter;
        }


        private void ButtonCalc(object sender, EventArgs e)
        {

            presenter.Calculate(Item1, Item2, num);



        }

        public void GetResult(string res)
        {

            resultLable.Text = res;

            result = resultLable.Text;
            AddUserInfo(res);
        }

        static async Task AddUserInfo(string result)
        {
            /* con.Open();
             cmd = new */
            /*DataAccess db = new DataAccess();*/
            /*db.GetUsers(Form2.instanse.tb1.Text.ToString(), EncryptString(ToSecureString(Form2.instanse.tb2.Text.ToString())), result);*/
            /*db.AddUsers("Max", "1234", result);*/

            /*using (DataBase1.ApplicationContext db = new DataBase1.ApplicationContext())
            {

                User one = new User { Output = result, Name = Form2.instanse.tb1.Text.ToString(), Password = EncryptString(ToSecureString(Form2.instanse.tb2.Text.ToString()))};
                db.Users.Add(one);
                db.SaveChanges();

            }*/
            string connectionString = "Server=WIN-S3MBIL1NUK7\\sqlexpress;Database=User;User ID=sa;Password=Maxakin_max; Encrypt=false;";
            string sqlExpression = $"INSERT INTO UserInfo (Name, Password, Output) VALUES ('{Form2.instanse.tb1.Text.ToString()}', '{EncryptString(ToSecureString(Form2.instanse.tb2.Text.ToString()))}', '{result}')";

            /*string sqlExpression = "DELETE FROM UserInfo ";*/


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);

                int number = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Добавлено объектов: {number}");
            }
            

            MessageBox.Show("Inserted");
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
    }
}
