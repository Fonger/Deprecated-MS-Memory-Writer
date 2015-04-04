using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MS_MemoryWriter
{
    public partial class frmAgreement : Form
    {
        public frmAgreement()
        {
            InitializeComponent();
        }

        private void frmAgreement_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        int a = 6;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = new Random().Next(100, 3000);
            a--;
            if (a == 0)
            {
                button1.Text="我同意 I agree...";
                timer1.Enabled = false;
                button1.Enabled = true;
            }
            else
            {
                button1.Text = "我同意 I agree..." + a.ToString();
            }

        }
    }
}
