using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private BankAccountCollection accounts;
        private TransactionCollection transactions;

        public Customer(string firstName, string lastName, BankAccountCollection accounts, 
            TransactionCollection transactions)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.accounts = accounts;
            this.transactions = transactions;
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public BankAccountCollection Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public TransactionCollection Transactions
        {
            get { return transactions; }
            set { transactions = value; }
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
