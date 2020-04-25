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
    public partial class AddWarehouseItem : Form
    {
        private string type;
        public AddWarehouseItem()
        {
            InitializeComponent();
            ItemType.Items.Add("Raw Materials");
            ItemType.Items.Add("Finished Goods");
        }

        public void ClearForm()
        {
            ItemCode.Text = "";
            ItemName.Text = "";
            ItemDes.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DataAccess db = new DataAccess();

                Item item = new Item();

                item.itemCode = ItemCode.Text.Trim();
                item.itemType = type;
                item.itemName = ItemName.Text.Trim();
                item.itemDes = ItemDes.Text.Trim();

                db.AddItem(item);

                ClearForm();
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(ItemCode.Text.Trim()))
            {
                errorProvider1.SetError(ItemCode, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(ItemName.Text.Trim()))
            {
                errorProvider1.SetError(ItemName, "Required");
                return false;
            }
            else if (string.IsNullOrEmpty(ItemDes.Text.Trim()))
            {
                errorProvider1.SetError(ItemDes, "Required");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            type = "";
            type = ItemType.SelectedItem.ToString();
        }
    }
}
