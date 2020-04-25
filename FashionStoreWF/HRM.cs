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
    }
}
