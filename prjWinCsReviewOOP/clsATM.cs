using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOP
{
    public class clsATM
    {
        private string vNumber;
        private string vCompany;
        private string vLocation;
        private string vStatus;
        private clsListClient vClient;
        private decimal vBalance;

        public clsATM(string number, string company, string location, string status, clsListAccounts client, string balance)
        {
            throw new System.NotImplementedException();
        }

        public clsATM()
        {
            throw new System.NotImplementedException();
        }

        public string Number
        {
            get => default;
            set
            {
            }
        }

        public string Company
        {
            get => default;
            set
            {
            }
        }

        public string Location
        {
            get => default;
            set
            {
            }
        }

        public string Status
        {
            get => default;
            set
            {
            }
        }

        public clsListAccounts Client
        {
            get => default;
            set
            {
            }
        }

        public decimal Balance
        {
            get => default;
            set
            {
            }
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public decimal Fill()
        {
            throw new System.NotImplementedException();
        }

        public void Close()
        {
            throw new System.NotImplementedException();
        }

        public void Display()
        {
            throw new System.NotImplementedException();
        }
    }
}