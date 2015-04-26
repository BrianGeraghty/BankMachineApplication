using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BizLogic;

namespace COMP2614Assign04
{
    public partial class TransactionHistoryDialog : Form
    {
        private static TransactionHistoryDialog instance;
        private Customer customer;

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private TransactionHistoryDialog()
        {
            InitializeComponent();
        }

        private void TransactionHistoryDialog_Load(object sender, EventArgs e)
        {
            updateTransactionList();
        }

        public static TransactionHistoryDialog CreateForm()
        {
            // make sure we only have one instance of this dialog
            if (instance == null)
            {
                instance = new TransactionHistoryDialog();
            }
            return instance;
        }

        // updates the customers transactions
        private void updateTransactionList()
        {
            // clear current content
            richTextBoxTransactionHistory.Text = string.Empty;

            if (Customer.Transactions.Count == 0)
            {
                richTextBoxTransactionHistory.Text = "<none>";
            }
            else if (checkBoxShowDetails.Checked)
            {
                // build a string with detailed information on all the customers transactions
                foreach (Transaction transaction in Customer.Transactions)
                {
                    richTextBoxTransactionHistory.AppendText(transaction.ToDetailedString());
                }
            }
            else
            {
                // build a string with basic information on all the customers transactions
                foreach (Transaction transaction in Customer.Transactions)
                {
                    richTextBoxTransactionHistory.AppendText(transaction.ToBasicString());
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TransactionHistoryDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        private void checkBoxShowDetails_CheckedChanged(object sender, EventArgs e)
        {
            updateTransactionList();
        }

        // called every second to update the list of transactions
        private void timerRefresh_Tick(object sender, EventArgs e)
        {            
            updateTransactionList();
        }
    }
}
