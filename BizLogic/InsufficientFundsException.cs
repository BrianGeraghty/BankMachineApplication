using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class InsufficientFundsException : Exception
    {
        private BankAccount account;
        private decimal transactionAmount;

        public InsufficientFundsException(BankAccount account, decimal transactionAmount)
            : base("There are not sufficient funds to perform this transaction")
        {
            this.account = account;
            this.transactionAmount = transactionAmount;
        }

        public BankAccount Account { get { return account; }}

        public decimal TransactionAmount { get { return transactionAmount; } }
    }
}
