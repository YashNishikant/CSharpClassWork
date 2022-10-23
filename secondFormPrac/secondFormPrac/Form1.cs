using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace secondFormPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bg1_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255,255,255);
        }

        private void bg2_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 34, 9);
        }

        private void bg3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(199, 235, 67);
        }

        private void tc2_CheckedChanged(object sender, EventArgs e)
        {
            tc2.ForeColor = Color.FromArgb(8, 77, 34);
            tc1.ForeColor = Color.FromArgb(0, 0, 0);
            tc3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void tc1_CheckedChanged(object sender, EventArgs e)
        {
             tc1.ForeColor = Color.FromArgb(199, 235, 67);
             tc2.ForeColor = Color.FromArgb(0, 0, 0);
             tc3.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void tc3_CheckedChanged(object sender, EventArgs e)
        {
            tc3.ForeColor = Color.FromArgb(8, 23, 176);
            tc2.ForeColor = Color.FromArgb(0, 0, 0);
            tc1.ForeColor = Color.FromArgb(0, 0, 0);
        }
    }
}
