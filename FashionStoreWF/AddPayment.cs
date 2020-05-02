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
    public partial class AddPayment : Form
    {
        public AddPayment()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm()
        {
            invoiceNum.Text = "";
            amount.Text = "";
            by.Text = "";
            to.Text = "";
            bank.Text = "";
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(invoiceNum.Text.Trim()))
            {
                errorProvider1.SetError(invoiceNum, "Required!");
                return false;
            }
            else if (string.IsNullOrEmpty(amount.Text.Trim()))
            {
                errorProvider1.SetError(amount, "Required!");
                return false;
            }
            else if (string.IsNullOrEmpty(by.Text.Trim()))
            {
                errorProvider1.SetError(by, "Required!");
                return false;
            }
            else if (string.IsNullOrEmpty(to.Text.Trim()))
            {
                errorProvider1.SetError(to, "Required!");
                return false;
            }
            else if (string.IsNullOrEmpty(bank.Text.Trim()))
            {
                errorProvider1.SetError(bank, "Required!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            DataAccess db = new DataAccess();

            //invoiceNum.Text = "";
            //amount.Text = "";
            //by.Text = "";
            //to.Text = "";
            //bank.Text = "";

            if (ValidateForm())
            {
                payment.p_invoiceNum = invoiceNum.Text.Trim();
                payment.p_amount = float.Parse(amount.Text.Trim());
                payment.p_paidBy = by.Text.Trim();
                payment.p_paidTo = to.Text.Trim();
                payment.p_bank = bank.Text.Trim();

                db.AddPayment(payment);

                ClearForm();
            }
        }
    }
}
