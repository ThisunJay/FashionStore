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
    public partial class FinishGood : Form
    {
        private string fileName;

        public FinishGood()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        public void ClearForm() 
        {
            styleNum.Text = "";
            Num.Text = "";
            pictureBox2.Image = null;
        }

        public bool ValidateForm()
        {
            if (string.IsNullOrEmpty(styleNum.Text.Trim()))
            {
                errorProvider1.SetError(styleNum, "Required!");
                return false;
            }
            else if (string.IsNullOrEmpty(Num.Text.Trim()))
            {
                errorProvider1.SetError(Num, "Required!");
                return false;
            }
            else if (pictureBox2.Image == null)
            {
                errorProvider1.SetError(pictureBox2, "Required!");
                return false;
            }
            return true;
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            File.Copy(fileName, Path.Combine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\\images", Path.GetFileName(fileName)), true);

            if (ValidateForm())
            {
                FinishGoods finishGoods = new FinishGoods();
                DataAccess db = new DataAccess();

                finishGoods.f_styleNum = styleNum.Text.Trim();
                finishGoods.f_num = int.Parse(Num.Text.Trim());
                finishGoods.f_image = Path.GetFileName(fileName);

                db.AddFinishGood(finishGoods);
                ClearForm();
            }
        }

        private void imageSel_Click(object sender, EventArgs e)
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
    }
}
