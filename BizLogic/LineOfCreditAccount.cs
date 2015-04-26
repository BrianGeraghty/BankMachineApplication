using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class LineOfCreditAccount : BankAccount
    {
        private decimal creditLimit;

        public decimal CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }

        public LineOfCreditAccount(decimal accountBalance, bool isActive, decimal creditLimit)
            : base(accountBalance, isActive)
        {
            this.creditLimit = creditLimit;
        }

        public override decimal CalculateAvailableFunds()
        {
            return (decimal)(CreditLimit + AccountBalance);
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", "Line of Credit", base.ToString());
        }      
    }
}
