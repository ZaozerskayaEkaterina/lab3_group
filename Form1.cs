using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVar4_Click(object sender, EventArgs e)
        {
            Variant_4 variantForm = new Variant_4();
            variantForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Variant5 variant5 = new Variant5();
            variant5.Show();
        }
    }
}
