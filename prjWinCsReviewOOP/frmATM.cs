using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsReviewOOP
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        private void frmATM_Load(object sender, EventArgs e)
        {
            txtdeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;


            this.Height = 172;
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            this.Height = 286;
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            this.Height = 455;
        }

        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            this.Height = 588;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            this.Height = 800;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 172;
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtdeposit.Visible = true;
            lblDeposit.Visible = true;
            txtdeposit.Focus();
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = true;
            lblWithdraw.Visible = true;
            txtWithdraw.Focus();
        }

        private void radConsult_CheckedChanged(object sender, EventArgs e)
        {
            txtdeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;

           

        }

        private void txtdeposit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {

                e.Handled = true; // do not allow the character be displayed on the box 

            }
        }

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {

                e.Handled = true; // do not allow the character be displayed on the box 

            }

        }
    }
}
