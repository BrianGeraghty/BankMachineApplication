using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class TransferFundsException : Exception
    {
        private BankAccount account;

        public TransferFundsException(BankAccount account)
            : base("FromAccount and ToAccount cannot be the same. Please change one of your selections.")
        {
            this.account = account;
        }

        public BankAccount Account { get { return account; } }
    }
}
