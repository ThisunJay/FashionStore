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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void ShowHRM() 
        {
            this.Hide();
            HRM hRM = new HRM();
            hRM.ShowDialog();
        }

        public void ShowMarketing() 
        {
            this.Hide();
            Marketing marketing = new Marketing();
            marketing.ShowDialog();
        }

        public void ShowWarehouse()
        {
            this.Hide();
            Warehouse warehouse = new Warehouse();
            warehouse.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowMarketing();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowHRM();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowHRM();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ShowHRM();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowWarehouse();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowWarehouse();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ShowWarehouse();
        }
    }
}
