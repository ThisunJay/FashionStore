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
    public partial class Marketing : Form
    {
        public Marketing()
        {
            InitializeComponent();
        }

        private void backDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetAllCustomers();
            var bindingList = new BindingList<Customer>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetAllSuppliers();
            var bindingList = new BindingList<Supplier>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddSupplier addSupplier = new AddSupplier();
            addSupplier.ShowDialog();
        }
    }
}
