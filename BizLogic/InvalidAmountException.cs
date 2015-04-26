using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class InvalidAmountException : Exception
    {
        private decimal transactionAmount;

        public InvalidAmountException(decimal transactionAmount)
            : base("Invalid transaction amount. Amount must be greater than $0.00")
        {
            this.transactionAmount = transactionAmount;
        }

        public decimal TransactionAmount { get { return transactionAmount; } }
    }
}
