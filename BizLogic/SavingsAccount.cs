using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(decimal accountBalance, bool isActive)
            : base(accountBalance, isActive)
        {

        }

        public override decimal CalculateAvailableFunds()
        {
            return (decimal)AccountBalance;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", "Savings", base.ToString());
        }
    }
}
