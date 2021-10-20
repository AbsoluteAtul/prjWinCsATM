namespace prjWinCsReviewOOP
{
    partial class frmATM
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNextNumber = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnNextPin = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboAccounts = new System.Windows.Forms.ComboBox();
            this.btnNextAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.radConsult = new System.Windows.Forms.RadioButton();
            this.radWithdraw = new System.Windows.Forms.RadioButton();
            this.radDeposit = new System.Windows.Forms.RadioButton();
            this.btnNextTransaction = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROYALE BANK - ATM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNextNumber);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(696, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Identification";
            // 
            // btnNextNumber
            // 
            this.btnNextNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextNumber.Location = new System.Drawing.Point(563, 43);
            this.btnNextNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextNumber.Name = "btnNextNumber";
            this.btnNextNumber.Size = new System.Drawing.Size(100, 31);
            this.btnNextNumber.TabIndex = 2;
            this.btnNextNumber.Text = "Next >>";
            this.btnNextNumber.UseVisualStyleBackColor = true;
            this.btnNextNumber.Click += new System.EventHandler(this.btnNextNumber_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(219, 49);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(335, 24);
            this.txtNumber.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter your number :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblWelcome);
            this.groupBox2.Controls.Add(this.btnNextPin);
            this.groupBox2.Controls.Add(this.txtPin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 169);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(696, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PIN Verification";
            // 
            // lblWelcome
            // 
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Location = new System.Drawing.Point(79, 23);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(282, 28);
            this.lblWelcome.TabIndex = 4;
            // 
            // btnNextPin
            // 
            this.btnNextPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPin.Location = new System.Drawing.Point(563, 55);
            this.btnNextPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextPin.Name = "btnNextPin";
            this.btnNextPin.Size = new System.Drawing.Size(100, 36);
            this.btnNextPin.TabIndex = 3;
            this.btnNextPin.Text = "Next >>";
            this.btnNextPin.UseVisualStyleBackColor = true;
            this.btnNextPin.Click += new System.EventHandler(this.btnNextPin_Click);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(205, 63);
            this.txtPin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '*';
            this.txtPin.Size = new System.Drawing.Size(132, 23);
            this.txtPin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter your PIN :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboAccounts);
            this.groupBox3.Controls.Add(this.btnNextAccount);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(16, 310);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(696, 92);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account Types";
            // 
            // cboAccounts
            // 
            this.cboAccounts.FormattingEnabled = true;
            this.cboAccounts.Location = new System.Drawing.Point(188, 36);
            this.cboAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Size = new System.Drawing.Size(160, 25);
            this.cboAccounts.TabIndex = 4;
            // 
            // btnNextAccount
            // 
            this.btnNextAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextAccount.Location = new System.Drawing.Point(563, 39);
            this.btnNextAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextAccount.Name = "btnNextAccount";
            this.btnNextAccount.Size = new System.Drawing.Size(100, 28);
            this.btnNextAccount.TabIndex = 3;
            this.btnNextAccount.Text = "Next >>";
            this.btnNextAccount.UseVisualStyleBackColor = true;
            this.btnNextAccount.Click += new System.EventHandler(this.btnNextAccount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select your account :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblWithdraw);
            this.groupBox4.Controls.Add(this.lblDeposit);
            this.groupBox4.Controls.Add(this.txtWithdraw);
            this.groupBox4.Controls.Add(this.txtdeposit);
            this.groupBox4.Controls.Add(this.radConsult);
            this.groupBox4.Controls.Add(this.radWithdraw);
            this.groupBox4.Controls.Add(this.radDeposit);
            this.groupBox4.Controls.Add(this.btnNextTransaction);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(16, 410);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(696, 123);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transaction";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.Location = new System.Drawing.Point(347, 63);
            this.lblWithdraw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(21, 20);
            this.lblWithdraw.TabIndex = 10;
            this.lblWithdraw.Text = "$";
            // 
            // lblDeposit
            // 
            this.lblDeposit.Location = new System.Drawing.Point(347, 36);
            this.lblDeposit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(21, 20);
            this.lblDeposit.TabIndex = 9;
            this.lblDeposit.Text = "$";
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.Location = new System.Drawing.Point(205, 63);
            this.txtWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(132, 23);
            this.txtWithdraw.TabIndex = 8;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWithdraw_KeyPress);
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(205, 31);
            this.txtdeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(132, 23);
            this.txtdeposit.TabIndex = 7;
            this.txtdeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdeposit_KeyPress);
            // 
            // radConsult
            // 
            this.radConsult.AutoSize = true;
            this.radConsult.Checked = true;
            this.radConsult.Location = new System.Drawing.Point(56, 92);
            this.radConsult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radConsult.Name = "radConsult";
            this.radConsult.Size = new System.Drawing.Size(83, 21);
            this.radConsult.TabIndex = 6;
            this.radConsult.TabStop = true;
            this.radConsult.Text = "Consult";
            this.radConsult.UseVisualStyleBackColor = true;
            this.radConsult.CheckedChanged += new System.EventHandler(this.radConsult_CheckedChanged);
            // 
            // radWithdraw
            // 
            this.radWithdraw.AutoSize = true;
            this.radWithdraw.Location = new System.Drawing.Point(56, 64);
            this.radWithdraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radWithdraw.Name = "radWithdraw";
            this.radWithdraw.Size = new System.Drawing.Size(95, 21);
            this.radWithdraw.TabIndex = 5;
            this.radWithdraw.Text = "Withdraw";
            this.radWithdraw.UseVisualStyleBackColor = true;
            this.radWithdraw.CheckedChanged += new System.EventHandler(this.radWithdraw_CheckedChanged);
            // 
            // radDeposit
            // 
            this.radDeposit.AutoSize = true;
            this.radDeposit.Location = new System.Drawing.Point(56, 36);
            this.radDeposit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radDeposit.Name = "radDeposit";
            this.radDeposit.Size = new System.Drawing.Size(84, 21);
            this.radDeposit.TabIndex = 4;
            this.radDeposit.Text = "Deposit";
            this.radDeposit.UseVisualStyleBackColor = true;
            this.radDeposit.CheckedChanged += new System.EventHandler(this.radDeposit_CheckedChanged);
            // 
            // btnNextTransaction
            // 
            this.btnNextTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTransaction.Location = new System.Drawing.Point(563, 36);
            this.btnNextTransaction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNextTransaction.Name = "btnNextTransaction";
            this.btnNextTransaction.Size = new System.Drawing.Size(100, 36);
            this.btnNextTransaction.TabIndex = 3;
            this.btnNextTransaction.Text = "Next >>";
            this.btnNextTransaction.UseVisualStyleBackColor = true;
            this.btnNextTransaction.Click += new System.EventHandler(this.btnNextTransaction_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblAccount);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(16, 540);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(696, 155);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Account Information";
            // 
            // lblAccount
            // 
            this.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccount.Location = new System.Drawing.Point(12, 37);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(623, 97);
            this.lblAccount.TabIndex = 0;
            // 
            // btnTerminate
            // 
            this.btnTerminate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminate.Location = new System.Drawing.Point(138, 703);
            this.btnTerminate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(432, 43);
            this.btnTerminate.TabIndex = 7;
            this.btnTerminate.Text = "<< Terminate >>";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 541);
            this.Controls.Add(this.btnTerminate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmATM";
            this.Text = "Application for Banking Machine";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNextNumber;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnNextPin;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboAccounts;
        private System.Windows.Forms.Button btnNextAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.RadioButton radConsult;
        private System.Windows.Forms.RadioButton radWithdraw;
        private System.Windows.Forms.RadioButton radDeposit;
        private System.Windows.Forms.Button btnNextTransaction;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnTerminate;
    }
}