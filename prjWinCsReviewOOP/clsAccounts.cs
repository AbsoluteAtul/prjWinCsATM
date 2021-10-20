using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjWinCsReviewOOP
{
    public class clsAccounts
    {
        private String vNumber;
        private string vType;
        private clsDate vOpendate;
        private string vStatus;
        private decimal vBalance;

        public clsAccounts()
        {
            vNumber = vType = vStatus = "Not Defined";
            vOpendate = new clsDate();
            vBalance = -1;

        }

        public clsAccounts(string number, string type, int day, int month, int year, string status, decimal balance)
        {
            Number = number;
            Type = type;
            vOpendate = new clsDate(day, month, year);
            vStatus = status;
            vBalance = balance;

        }

        ~clsAccounts()
        {
            throw new System.NotImplementedException();
        }

        public string Number
        {
            get => vNumber;
            set
            {
                vNumber = value;
            }
        }

        public string Type
        {
            get => vType;
            set
            {
                vType = value;

            }
        }

        public clsDate Opendate
        {
            get => vOpendate;
           
        }

        public string Status
        {
            get => vStatus;
            
        }

        public decimal Balance
        {
            get => vBalance;
           
        }

        public void Open(string number, string type)
        {
            Number = number;
            Type = type;
            vOpendate = new clsDate(DateTime.Today.Day,DateTime.Today.Month, DateTime.Today.Year);
            vStatus = "active";
            vBalance = 0;
        }
        /// <summary>
        /// //returns true when deposit is successful
        /// </summary>

        public bool Deposit(decimal amount)
        {
            if(amount >= 2 && amount <= 20000)
            {
                vBalance = vBalance + amount; // vBalnce +=amount
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// returns 0 (for success), 1 (for  Maximum), 2(for Minimum), -1(Multiple 20), -2 (insufficient funds )
        /// </summary>
        public int Withdraw(decimal amount)
        {
            if(amount > 500) { return 1; }
            else if (amount < 20) { return 2; }
            else if ((amount % 20) != 0) { return -1; }
            else if (amount > vBalance) { return -2; }
            else
            {
                vBalance = vBalance - amount;
                return 0;
            }
        }

        public string Consult()
        {
            string info = "Number :" + vNumber + "\nType :" + vType + "\nStatus : " + vStatus + "\n Open Date : "
                 + vOpendate.toNumber() + "\nBalance: $" + vBalance + "\n";
            return info;
        }
        public void Close()
        {
            vStatus = "Closed";
        }
    }
}