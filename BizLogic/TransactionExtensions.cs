using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizLogic
{
    public static class TransactionExtensions
    {
        // if the ShowDetails box on the transaction history dialog is checked
        // this method is called to generate the display data
        public static string ToDetailedString(this Transaction input)
        {
            string transactionType;

            if (input is WithdrawalTransaction)
            {
                transactionType = "Withdrawal";
                WithdrawalTransaction temp = input as WithdrawalTransaction;

                // build and return the string to be displayed in the transactionHistory dialog
                return string.Format("{0} {1} {2} \r\n{3, 17}{4} \r\n{5, 15} {6:N2}\r\n\r\n",
                input.TransactionTime.Date.ToString("yyyy-MM-dd"),
                transactionType,
                input.Status == TransactionStatus.Pending ? "[Pending]" : " ",
                "Account: ", temp.FromAccount.AccountNumber, "Amount:", input.Amount);
            }
            else if (input is DepositTransaction)
            {
                transactionType = "Deposit";
                DepositTransaction temp = input as DepositTransaction;

                // build and return the string to be displayed in the transactionHistory dialog
                return string.Format("{0} {1} {2} \r\n{3, 17}{4} \r\n{5, 15} {6:N2}\r\n\r\n",
                input.TransactionTime.Date.ToString("yyyy-MM-dd"),
                transactionType,
                input.Status == TransactionStatus.Pending ? "[Pending]" : " ",
                "Account: ", temp.ToAccount.AccountNumber, "Amount:", input.Amount);
            }
            else if (input is TransferFundsTransaction)
            {
                transactionType = "Transfer Funds";

                TransferFundsTransaction temp = input as TransferFundsTransaction;

                // build and return the string to be displayed in the transactionHistory dialog
                return string.Format("{0} {1} {2} \r\n{3, 22}{4} \r\n{5, 20}{6} \r\n{7, 15} {8:N2}\r\n\r\n",
                input.TransactionTime.Date.ToString("yyyy-MM-dd"),
                transactionType,
                input.Status == TransactionStatus.Pending ? "[Pending]" : " ",
                "From Account: ", temp.FromAccount.AccountNumber,
                "To Account: ", temp.ToAccount.AccountNumber,
                "Amount:", input.Amount);
            }
            return String.Empty;
        }

        // if the ShowDetails box on the transaction history dialog is not checked
        // this method is called to generate the display data 
        public static string ToBasicString(this Transaction input)
        {
            string transactionType;

            if (input is WithdrawalTransaction)
            {
                transactionType = "Withdrawal";
            }
            else if (input is DepositTransaction)
            {
                transactionType = "Deposit";
            }
            else
            {
                transactionType = "Transfer Funds";
            }

            return string.Format("{0} {1} {2}\r\n",
                input.TransactionTime.Date.ToString("yyyy-MM-dd"),
                transactionType,
                input.Status == TransactionStatus.Pending ? "[Pending]" : " ");
        }
    }
}
