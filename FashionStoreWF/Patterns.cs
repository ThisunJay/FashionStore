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

        public void Populate(String[] imagesList)
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(100, 100);

            var path = Directory.GetFiles(Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\\images", "*.*");

            List<string> paths = null;

            for (int i = 0; i < imagesList.Length; i++)
            {
                var onePaths = getImages(path, imagesList[i]);

                paths.Add(onePaths);
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

        private void getImgs_Click(object sender, EventArgs e)
        {
            Populate();
        }

        private void finishGoodsBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var AllGoods = db.GetFinishGoods();

            String[] images = null;

            for (int i = 0; i < AllGoods.Count; i++)
            {
                images[i] = AllGoods[i].f_image;
            }

            Populate(images);
        }

        private void PatternsBtn_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            var AllPatterns = db.GetAllPatterns();

            String[] images = null;

            for (int i = 0; i < AllPatterns.Count; i++)
            {
                images[i] = AllPatterns[i].p_image;
            }

            Populate(images);
        }
    }
}
