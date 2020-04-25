using FashionStoreWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreWF
{
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegBtn_Click(object sender, EventArgs e)
        {
            User user = new User();
            DataAccess db = new DataAccess();

            if (ValidateForm() && CheckPassword(Password.Text.Trim(), CPassword.Text.Trim()))
            {
                string hashedPassword = PasswordHasher.Hash(Password.Text.Trim());

                user.email = Email.Text.Trim();
                user.e_password = hashedPassword;
                user.u_name = UserName.Text.Trim();

                db.AddUser(user);

                Email.Text = "";
                UserName.Text = "";
                Password.Text = "";
                CPassword.Text = "";
            }

            //db.GetUsers();
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(Email.Text.Trim()))
            {
                errorProvider1.SetError(Email, "Email is required!");
                return false;
            }
            else if (string.IsNullOrEmpty(UserName.Text.Trim()))
            {
                errorProvider1.SetError(UserName, "User name is required!");
                return false;
            }
            else if (string.IsNullOrEmpty(Password.Text.Trim()))
            {
                errorProvider1.SetError(Password, "Password is required!");
                return false;
            }
            else if (string.IsNullOrEmpty(CPassword.Text.Trim()))
            {
                errorProvider1.SetError(CPassword, "Con. Password is required!");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckPassword(string pwd, string cpwd)
        {
            if (string.Equals(pwd, cpwd))
                return true;
            else
                return false;
        }

        private void backToLgn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }
    }
}
