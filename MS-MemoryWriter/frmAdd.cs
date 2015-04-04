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
    public partial class frmAdd : Form
    {
        public frmAdd()
        {
            InitializeComponent();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                switch (MSTAB.SelectedIndex)
                {
                    case 0:
                        Convert.ToInt32(txtAddress.Text, 16);
                        break;
                    case 1:
                        Convert.ToInt32(txtAOP.Text, 16);
                        Convert.ToInt32(txtOffset.Text, 16);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("數值格式輸入錯誤\nValue Error!","MS-Memory Writer by nimo1993", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                return;
            }

        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            comType.SelectedIndex = 2;
        }

        private void comType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

            if (txtName.Text.IndexOf("|N-O") != -1)
            {
                MessageBox.Show("Please remove |N-O");
                txtName.Text = "";
            }

                
        }

        private void txtASM_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.IndexOf("|N-O") != -1)
            {
                MessageBox.Show("Please remove |N-O|");
                txtName.Text = txtName.Text.Replace("|N-O", "");
            }
        }
    }
}
