using Manager;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Converter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            /*string connectionString = "Server=WIN-S3MBIL1NUK7\\sqlexpress ;Database=User;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";*/
            /*string connectionString = "data source=WIN-S3MBIL1NUK7\\sqlexpress;initial catalog=UserInfo;Integrated Security=True ;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=true";*/
           /* string connectionString = "Server=WIN-S3MBIL1NUK7\\sqlexpress;Database=User;User ID=sa;Password=Maxakin_max; Encrypt=false;";

            string sqlExpression = "INSERT INTO UserInfo (Name, Password, Output) VALUES ('Tom', 'efwefw123', 'agrgrg')";

            *//*string sqlExpression = "DELETE FROM UserInfo ";*//*


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                
                int number = await command.ExecuteNonQueryAsync();
                Console.WriteLine($"Добавлено объектов: {number}");
            }
            Console.Read();*/
            ApplicationConfiguration.Initialize();

            Form2 winForm = new Form2();
           
            Application.Run(winForm);



            
        }

        
    
    }
}