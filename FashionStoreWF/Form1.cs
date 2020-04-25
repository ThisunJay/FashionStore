using FashionStoreWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterUser registerUser = new RegisterUser();
            registerUser.ShowDialog();
            //NewPattern newPattern = new NewPattern();
            //newPattern.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var users = db.GetUser(UserName.Text.Trim());

            if (ValidateUser(users[0]))
            {
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid User Details!");
                UserName.Text = "";
                Password.Text = "";
            }
                
        }

        private bool ValidateUser(User user) 
        {
            string gotPwd = user.e_password;

            if (PasswordHasher.Verify(Password.Text.Trim(), gotPwd))
                return true;

            return false;
                
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GetAllCustomers();
        }
    }
}
