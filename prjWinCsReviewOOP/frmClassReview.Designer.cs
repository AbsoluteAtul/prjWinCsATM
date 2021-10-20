namespace prjWinCsReviewOOP
{
    partial class frmClassReview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dateBdate = new System.Windows.Forms.DateTimePicker();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.btnTOGrade = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBJECT ORIENTATED PROGRAMMING";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(208, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(449, 24);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dateBdate
            // 
            this.dateBdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBdate.Location = new System.Drawing.Point(208, 128);
            this.dateBdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateBdate.Name = "dateBdate";
            this.dateBdate.Size = new System.Drawing.Size(449, 24);
            this.dateBdate.TabIndex = 4;
            this.dateBdate.ValueChanged += new System.EventHandler(this.dateBdate_ValueChanged);
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterStudent.Location = new System.Drawing.Point(172, 218);
            this.btnRegisterStudent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(130, 30);
            this.btnRegisterStudent.TabIndex = 5;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // btnTOGrade
            // 
            this.btnTOGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTOGrade.Location = new System.Drawing.Point(172, 270);
            this.btnTOGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTOGrade.Name = "btnTOGrade";
            this.btnTOGrade.Size = new System.Drawing.Size(130, 35);
            this.btnTOGrade.TabIndex = 6;
            this.btnTOGrade.Text = "Grade Student";
            this.btnTOGrade.UseVisualStyleBackColor = true;
            this.btnTOGrade.Click += new System.EventHandler(this.btnTOGrade_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(172, 324);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(165, 44);
            this.btnDisplay.TabIndex = 7;
            this.btnDisplay.Text = "Display Student";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(352, 275);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(124, 24);
            this.txtGrade.TabIndex = 8;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            this.txtGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGradeKeypress);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(535, 356);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(492, 191);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // frmClassReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 623);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnTOGrade);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.dateBdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmClassReview";
            this.Text = "frmClassReview";
            this.Load += new System.EventHandler(this.frmClassReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dateBdate;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Button btnTOGrade;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lblInfo;
    }
}