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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            string info ="Are you sure to quit this program ? ";
            string title = "Application Closing";

            if (MessageBox.Show(info,title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void mnuATM_Click(object sender, EventArgs e)
        {
            frmATM myAtm = new frmATM();
            // indicate to myAtm that it is the child of the current form i.e frmMain(this)

            myAtm.MdiParent = this; // this refers to the class in which you are.
            myAtm.Show();
        }

        private void mnuOOP_Click(object sender, EventArgs e)
        {
            frmClassReview fc = new frmClassReview();

            // indicate to fc that it is the child of the current form i.e frmMain(this)

            fc.MdiParent = this; // this refers to the class in which you are.
            fc.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsAccounts myac = new clsAccounts();
            MessageBox.Show(myac.Consult());
            myac.Open("ac1ac1", "Chequing");
            myac.Deposit(25000);
            MessageBox.Show(myac.Consult());
            myac.Deposit(700);
            MessageBox.Show(myac.Consult());
            
            MessageBox.Show(myac.Withdraw(600).ToString());

            MessageBox.Show(myac.Consult());
        }
    }
}
