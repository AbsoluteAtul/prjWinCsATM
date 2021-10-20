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
    
    public partial class frmClassReview : Form
    {
        //private struct Time
        //{
        //    public Int16 Hour;
        //    public Int16 Minute;
        //    public Int16 Seconds;


        //}
        public frmClassReview()
        {
            InitializeComponent();
        }
        //private void display (Time anytime)
        //{
        //    this.Text = anytime.Hour + ": " + anytime.Minute + ": " + anytime.Seconds;
        //}
        clsStudent mystud;

        private void frmClassReview_Load(object sender, EventArgs e)
        {

            // //Time rv;
            // //rv.Hour = 15;
            // //rv.Minute = 20;
            // //rv.Seconds = 15;
            // //display(rv);
            // clsTime RV = new clsTime();
            // RV.Adjust(15, 200,- 10);
            // lblResult.Text = RV.DisplayUniversal();
            // lblresult2.Text = RV.DisplayStandard();

            //// RV.Hour = 45;  // for writing
            // //RV.Minute = 200;
            // //RV.Second = 115;


            //clsDate bday = new clsDate(23,11,2000);
            //// bday.Day = 23;
            // //bday.Month = -11;
            // //bday.Year = 2000;
            // bday.Intialize(5,10,2001);
            // lblBday.Text = bday.toNumber();
            // lblDateLetter.Text = bday.toLetter();

            //clsStudent St1 = new clsStudent();

            //St1.Register("Marco Pollo", 23, 11, 2000);

            //if (St1.toGrade (85) == false)
            //{
            //    MessageBox.Show("invalid grade");

            //}
            //MessageBox.Show(St1.Display());
            //lblResult.Text = St1.Display();

            mystud = new clsStudent();

            
           




        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int dy = dateBdate.Value.Day;
            int mt = dateBdate.Value.Month;
            int yr = dateBdate.Value.Year;

            mystud.Register(name, dy, mt, yr);

            btnRegisterStudent.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateBdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTOGrade_Click(object sender, EventArgs e)
        {
            Single grade = Convert.ToSingle(txtGrade.Text);
            if (mystud.toGrade(grade) == true)
            {
                MessageBox.Show("Grading Succeede !");
            }
            else {
                MessageBox.Show("Grading Failed, Invalid grade !");
                 }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblInfo.Text = mystud.Display();
        }

        private void txtGrade_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtGradeKeypress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar)==false && char .IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
