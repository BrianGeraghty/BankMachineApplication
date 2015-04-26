using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class WithdrawalTransaction : Transaction
    {
        BankAccount fromAccount;

        public WithdrawalTransaction(Customer customer, decimal amount, BankAccount fromAccount)
            : base(customer, amount)
        {
            this.fromAccount = fromAccount;
        }

        public BankAccount FromAccount
        {
            get { return fromAccount; }
        }

        // validates the data entered before completing a withdrawel transaction
        // if any data is invalid an exception is thrown
        override public void doTransaction() 
        {
            if (!FromAccount.IsActive) 
            {
                throw new InactiveAccountException(FromAccount);
            }
            else if (Amount <= (decimal)0.00)
            {
                throw new InvalidAmountException(Amount);
            }
            else if (Amount > FromAccount.CalculateAvailableFunds())
            {
                throw new InsufficientFundsException(fromAccount, Amount);
            }
            else
            {
                FromAccount.AccountBalance -= Amount;
                Status = TransactionStatus.Complete;
                Customer.Transactions.Add(this);
            }
        }

        public override void Process()
        {

        }
    }
}
