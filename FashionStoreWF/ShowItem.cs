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
    public partial class ShowItem : Form
    {
        public ShowItem()
        {
            InitializeComponent();
        }

        public void setDetails(Image img, string text)
        {
            pictureBox1.Image = img;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            label1.Text = text;
        }
    }
}
