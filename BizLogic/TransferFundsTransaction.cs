using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class TransferFundsTransaction : Transaction
    {
        private BankAccount fromAccount;
        private BankAccount toAccount;

        public TransferFundsTransaction(Customer customer, decimal amount, BankAccount fromAccount, 
            BankAccount toAccount) : base(customer, amount)
        {
            this.fromAccount = fromAccount;
            this.toAccount = toAccount;
        }

        // doTransaction validates that the data entered for the transfer funds transaction
        // is valid before completing the transaction. If any of the data is invalid an
        // exception is thrown 
        override public void doTransaction() 
        {
            if (FromAccount == ToAccount)
            {
                throw new TransferFundsException(FromAccount);
            }
            else if (!FromAccount.IsActive)
            {
                throw new InactiveAccountException(FromAccount);
            }
            else if (!ToAccount.IsActive)
            {
                throw new InactiveAccountException(ToAccount);
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
                ToAccount.AccountBalance += Amount;
                Status = TransactionStatus.Complete;
                Customer.Transactions.Add(this);
            }
        }

        public override void Process()
        {

        }

        public BankAccount FromAccount
        {
            get { return fromAccount; }
            set { fromAccount = value; }
        }

        public BankAccount ToAccount
        {
            get { return toAccount; }
            set { toAccount = value; }
        }
    }
}
