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
    public partial class HRM : Form
    {
        public HRM()
        {
            InitializeComponent();
        }

        private void adEmpBtn_Click(object sender, EventArgs e)
        {
            EmployeeRegistration employeeRegistration = new EmployeeRegistration();
            employeeRegistration.ShowDialog();
        }

        private void empBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetAllEmployees();
            var bindingList = new BindingList<Employee>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MarkAttendance markAttendance = new MarkAttendance();
            markAttendance.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetAttendance();
            var bindingList = new BindingList<Attendance>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddPayment addPayment = new AddPayment();
            addPayment.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetPayments();
            var bindingList = new BindingList<Payment>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void dBoard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.ShowDialog();
        }
    }
}
