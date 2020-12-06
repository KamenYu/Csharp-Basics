using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgn_to_euro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void FormConverter_Load(object sender, EventArgs e)
        {
            Convert();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Convert();
        }

        void Convert()
        {
            var amountBGN = this.numericUpDownAmount.Value;
            var amountEUR = amountBGN / 1.95583m;
            this.labelResult.Text = amountBGN + " BGN = " + Math.Round(amountEUR, 2) + " EUR";
        }

        private void labelResult_Click(object sender, EventArgs e)
        {
            Convert();
        }
    }
}
