using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class InactiveAccountException : Exception
    {
        private BankAccount account;

        public InactiveAccountException(BankAccount account)
            : base("This account is inactive.")
        {
            this.account = account;
        }

        public BankAccount Account{ get { return account; } }
    }
}
