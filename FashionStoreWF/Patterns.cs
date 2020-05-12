using FashionStoreWF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionStoreWF
{
    public partial class Patterns : Form
    {
        public Patterns()
        {
            InitializeComponent();

            listView1.View = View.Details;

            listView1.Columns.Add("Image", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        //Populate List View

        public void Populate()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            var path = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\\images", "*.*");

            foreach (var item in path)
            {
                imgs.Images.Add("Image", Image.FromFile(item));
            }

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imgs;

            for (int i = 0; i < imgs.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "cal icon";
                listView1.Items.Add(lvi);
            }

        }

        public void Populate(List<Pattern> patterns)
        {
            listView1.Items.Clear();

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            var path = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\\images", "*.*");

            string[] paths = { "tem1" };

            for (int i = 0; i < patterns.Count; i++)
            {

                foreach (var item in path)
                {
                    if (item.Contains(patterns[i].p_image))
                    {
                        paths[i] = item;
                    }
                }
            }

            foreach (var item in paths)
            {
                imgs.Images.Add("Image", Image.FromFile(item));
            }

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imgs;

            for (int i = 0; i < imgs.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "cal icon";
                listView1.Items.Add(lvi);
            }

        }

        public void Populate(List<FinishGoods> goods)
        {
            listView1.Items.Clear();

            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            var path = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\\images", "*.*");

            string[] paths = { "tem1" };

            for (int i = 0; i < goods.Count; i++)
            {

                foreach (var item in path)
                {
                    if (item.Contains(goods[i].f_image))
                    {
                        paths[i] = item;
                    }
                }
            }

            foreach (var item in paths)
            {
                imgs.Images.Add("Image", Image.FromFile(item));
            }

            listView1.View = View.LargeIcon;
            listView1.LargeImageList = imgs;

            for (int i = 0; i < imgs.Images.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = "cal icon";
                listView1.Items.Add(lvi);
            }

            //destroying objects
        }

        public string getImages(string[] files, string imageName)
        {
            foreach (var item in files)
            {
                var con = item.Contains(imageName);
                if (con == true)
                    return item;
            }

            return "Nothing";
        }

        private void ptnBtn_Click(object sender, EventArgs e)
        {
            NewPattern newPattern = new NewPattern();
            newPattern.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FinishGood finishGood = new FinishGood();
            finishGood.ShowDialog();
        }

        private void dBoard_Click(object sender, EventArgs e)
        {
            Dashboard form1 = new Dashboard();
            this.Hide();
            form1.ShowDialog();
        }

        private void finishGoodsBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var AllGoods = db.GetFinishGoods();

            Populate(AllGoods);
        }

        private void PatternsBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var AllPatterns = db.GetAllPatterns();

            Populate(AllPatterns);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count >= 1)
            {
                ListViewItem item = listView1.SelectedItems[0];

                if (item.Bounds.Contains(e.Location))
                {
                    var imgs = listView1.LargeImageList;
                    var img = imgs.Images[item.ImageIndex];
                    //MessageBox.Show("Double Clicked on :" + item.Text);
                    ShowItem showItem = new ShowItem();
                    showItem.setDetails(img, item.Text);
                    showItem.ShowDialog();
                }
            }
        }
    }
}
