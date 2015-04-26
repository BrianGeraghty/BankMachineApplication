using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public abstract class BankAccount
    {
        private static int nextAccountNumber = 1001;
        private int accountNumber;
        private decimal accountBalance;
        private bool isActive;

        public BankAccount(decimal accountBalance, bool isActive)
        {
            this.accountNumber = nextAccountNumber++;
            this.accountBalance = accountBalance;
            this.isActive = isActive;
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        
        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public abstract decimal CalculateAvailableFunds();

        public override string ToString()
        {
            return string.Format("{0}", accountNumber);
        } 
    }
}
