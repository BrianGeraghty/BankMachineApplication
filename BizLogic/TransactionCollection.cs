using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;

namespace BizLogic
{
    public class TransactionCollection : List<IProcessable>
    {

        public void ProcessPendingTransactions()
        {
            foreach (Transaction transaction in this)
            {
                // calculate the time passed since the transaction happened
                TimeSpan timePassed = DateTime.Now - transaction.TransactionTime;

                // if its been over 30 seconds since the transaction happened and the transaction 
                // is in Pending status then process the transaction
                if ((transaction.Status == TransactionStatus.Pending) && (timePassed.Seconds >= 30))
                {
                    transaction.Process();
                }
            }
        }
    }
}
