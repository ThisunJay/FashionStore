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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            Fname.Text = "";
            Lname.Text = "";
            Email.Text = "";
            Address.Text = "";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            if (ValidateForm())
            {
                Customer customer = new Customer();
                customer.FirstName = Fname.Text.Trim();
                customer.LastName = Lname.Text.Trim();
                customer.email = Email.Text.Trim();
                customer.c_address = Address.Text.Trim();

                db.AddCustomer(customer);
                Fname.Text = "";
                Lname.Text = "";
                Email.Text = "";
                Address.Text = "";
            }

        }

        public bool ValidateForm() 
        {
            if (string.IsNullOrEmpty(Fname.Text.Trim()))
            {
                errorProvider1.SetError(Fname, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(Lname.Text.Trim()))
            {
                errorProvider1.SetError(Lname, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(Email.Text.Trim()))
            {
                errorProvider1.SetError(Email, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(Address.Text.Trim()))
            {
                errorProvider1.SetError(Address, "Required");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
