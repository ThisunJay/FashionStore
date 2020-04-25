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
    public partial class NewPattern : Form
    {
        public string fileName;
        public NewPattern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(opnfd.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                fileName = opnfd.FileName;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //File.Copy(fileName, Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"image", Path.GetFileName(fileName)), true);
            File.Copy(fileName, Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\\images", Path.GetFileName(fileName)), true);
        }

        //Full file path can get from here.. you just need to change the file name, can be done using simple string manipulation
        //Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\\images\\art1 lib.jpg")

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
