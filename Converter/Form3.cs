using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }


        private void RegisterButton_Click(object sender, EventArgs e)
        {
            using (DataBase1.ApplicationContext db = new DataBase1.ApplicationContext()) { 
                User user = new User {UserName = RegisterNameTextBox.Text, Password = RegisterPasswordTextBox.Text, output = ""};

                db.Users.Add(user);
                db.SaveChanges();

            }
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
        }
    }
}
