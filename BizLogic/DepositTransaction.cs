using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class DepositTransaction : Transaction
    {
        BankAccount toAccount;

        public BankAccount ToAccount
        {
            get { return toAccount; }
            set { toAccount = value; }
        }
   
        public DepositTransaction(Customer customer,  decimal amount, BankAccount toAccount) 
            : base(customer, amount)
        {
            this.toAccount = toAccount;
        }

        override public void doTransaction() 
        {
            // check if the account is active
            if (!toAccount.IsActive) 
            {
                throw new InactiveAccountException(toAccount);
            }
            // check if amount is negative
            else if (Amount <= (decimal)0.00)
            {
                throw new InvalidAmountException(Amount);
            }
            else
            {
                // transaction is valid so set status to pending
                Status = TransactionStatus.Pending;
                Customer.Transactions.Add(this);   
            }
        }

        // Processes a deposit transaction by adding the deposit
        // amount to the balance and updating the transaction status
        public override void Process()
        {
            this.ToAccount.AccountBalance += this.Amount;
            this.Status = TransactionStatus.Complete;
        }
    }
}
