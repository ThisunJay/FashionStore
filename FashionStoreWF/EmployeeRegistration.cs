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
    public partial class EmployeeRegistration : Form
    {
        public EmployeeRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        public void clearForm()
        {
            EmpName.Text = "";
            EmpNIC.Text = "";
            EmpAddress.Text = "";
            EmpContactNum.Text = "";
            EmpJobRole.Text = "";
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(EmpName.Text.Trim()))
            {
                errorProvider1.SetError(EmpName, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(EmpNIC.Text.Trim()))
            {
                errorProvider1.SetError(EmpNIC, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(EmpAddress.Text.Trim()))
            {
                errorProvider1.SetError(EmpAddress, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(EmpContactNum.Text.Trim()))
            {
                errorProvider1.SetError(EmpContactNum, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(EmpJobRole.Text.Trim())) 
            {
                errorProvider1.SetError(EmpJobRole, "Required");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();

                Employee employee = new Employee();

                employee.e_name = EmpName.Text.Trim();
                employee.nic = EmpNIC.Text.Trim();
                employee.e_address = EmpAddress.Text.Trim();
                employee.e_contactNumber = EmpContactNum.Text.Trim();
                employee.e_jobrole = EmpJobRole.Text.Trim();

                db.AddEmployee(employee);

                clearForm();
            }
        }
    }
}
