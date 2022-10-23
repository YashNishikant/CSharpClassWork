using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFormPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,0,0);
        }

        private void bkg2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 255, 0);
        }

        private void tc1_CheckedChanged(object sender, EventArgs e)
        {
            tc1.ForeColor = Color.FromArgb(134, 54, 23);
        }

        private void tc2_CheckedChanged(object sender, EventArgs e)
        {
            tc2.ForeColor = Color.FromArgb(242, 123, 5);
        }
    }
}
