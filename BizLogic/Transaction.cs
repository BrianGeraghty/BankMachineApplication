using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public abstract class Transaction : IProcessable
    {
        private Customer customer;
        private DateTime transactionTime;
        private decimal amount;
        private TransactionStatus status;

        public Transaction(Customer customer, decimal amount)
        {
            this.customer = customer;
            this.transactionTime = DateTime.Now;
            this.amount = amount;
        }

        public abstract void Process();
        public abstract void doTransaction();

        public decimal Amount
        {
            get { return amount; }
        }

        public TransactionStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        public DateTime TransactionTime
        {
            get { return transactionTime; }
            set { transactionTime = value; }
        }

        public Customer Customer
        {
            get { return customer; }
        }

        public override string ToString()
        {
            return TransactionTime.Date.ToString("YYYY-MM-DD");
        }
    }
}
