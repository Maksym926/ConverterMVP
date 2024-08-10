using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBase1;
using Manager;

namespace Converter
{
    public partial class Form2 : Form
    {
        public static Form2 instanse;
        public Form2()
        {
            InitializeComponent();
            instanse = this;
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public TextBox tb1;
        public TextBox tb2;

        private void loginButton_Click(object sender, EventArgs e)
        {
            tb1 = UserNameTextBox;
            tb2 = PasswordtextBox;

            User user = new User();
            using (DataBase1.ApplicationContext db = new DataBase1.ApplicationContext())
            {
                
                var users = db.Users.ToList();
                foreach (DataBase1.User u in users)
                {
                    if (UserNameTextBox.Text == u.UserName && PasswordtextBox.Text == u.Password)
                    {
                        Form1 winForm = new Form1();
                        Model model = new Model();
                        Presenter presenter = new Presenter(model, winForm);
                        this.Hide();

                        winForm.Show();
                        break;
                    }

                }

            }
        }
        

        private void RegButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.Show();
        }
    }
}
