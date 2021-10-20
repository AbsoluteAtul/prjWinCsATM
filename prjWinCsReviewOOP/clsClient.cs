using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjWinCsReviewOOP
{
    public class clsClient
    {
        private string vName;
        private string vNumber;
        private string vStatus;
        private string vPin;
        private clsListAccounts vAccounts;

        public clsClient(string number, string name, string pin, string status, clsListAccounts account)
        {
            throw new System.NotImplementedException();
        }

        public clsClient()
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

        public string Name
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

        public string Pin
        {
            get => default;
            set
            {
            }
        }

        public clsListAccounts Accounts
        {
            get => default;
            set
            {
            }
        }

        public void Register(string name, string number, string pin)
        {
            throw new System.NotImplementedException();
        }

        public string Display()
        {
            throw new System.NotImplementedException();
        }
    }
}