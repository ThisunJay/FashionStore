using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FashionStoreWF.Models;

namespace FashionStoreWF
{
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddWarehouseItem addWarehouseItem = new AddWarehouseItem();
            addWarehouseItem.ShowDialog();
        }

        //ItemType.Items.Add("Raw Materials");
        //ItemType.Items.Add("Finished Goods");
        private void rawBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetItems("Raw Materials");
            var bindingList = new BindingList<Item>(list);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void finBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var list = db.GetItems("Finished Goods");
            var bindingList = new BindingList<Item>(list);
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
