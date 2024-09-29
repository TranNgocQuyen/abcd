using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, KetQua;
            a = int.Parse(txtA.Text);
            b = int.Parse(txtB.Text);
            KetQua = a + b;
            txtKetQua.Text = KetQua.ToString();
        }

        private void txtA_Click(object sender, EventArgs e)
        {

        }
    }
}
