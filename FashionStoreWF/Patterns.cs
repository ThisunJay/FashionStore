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
    public partial class Patterns : Form
    {
        public Patterns()
        {
            InitializeComponent();
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
    }
}
