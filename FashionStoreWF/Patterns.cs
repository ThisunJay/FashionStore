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

            var path1 = Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))) + @"\Images";
            var path2 = path1.Replace("\\", "/");

            var paths = Directory.GetFiles(path2, "*.*");

            try
            {
                foreach (var item in paths)
                {
                    imgs.Images.Add(Image.FromFile(item));
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            listView1.SmallImageList = imgs;
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
    }
}
