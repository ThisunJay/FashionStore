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
    public partial class AddSupplier : Form
    {
        public AddSupplier()
        {
            InitializeComponent();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            Name.Text = "";
            Email.Text = "";
            Phone.Text = "";
            Address.Text = "";
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(Name.Text.Trim()))
            {
                errorProvider1.SetError(Name, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(Email.Text.Trim()))
            {
                errorProvider1.SetError(Email, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(Phone.Text.Trim()))
            {
                errorProvider1.SetError(Phone, "Required");
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();
                
                Supplier supplier = new Supplier();
                
                supplier.s_name = Name.Text.Trim();
                supplier.email = Email.Text.Trim();
                supplier.phone = Phone.Text.Trim();
                supplier.s_address = Address.Text.Trim();

                db.AddSupplier(supplier);

                Name.Text = "";
                Email.Text = "";
                Phone.Text = "";
                Address.Text = "";
            }
        }
    }
}
