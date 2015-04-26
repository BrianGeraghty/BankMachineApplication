using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

using BizLogic;

namespace COMP2614Assign04
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();         
        }

        private Customer selectedCustomer;

        private void MainForm_Load(object sender, EventArgs e)
        {
            BankAccountCollection accounts = new BankAccountCollection();
            TransactionCollection transactions = new TransactionCollection();

            // create the customers accounts
            SavingsAccount account1 = new SavingsAccount((decimal)0.00, true);
            SavingsAccount account2 = new SavingsAccount((decimal)0.00, true);
            LineOfCreditAccount account3 = new LineOfCreditAccount((decimal)0.00, true, (decimal)10000);

            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            // create the customer
            selectedCustomer = new Customer("Charlie", "Harper", accounts, transactions);
            
            setupListView();
            // add the customers account details to the list view
            displayCustomerDetails();
            // set the text at the top of the main form
            this.Text = "Accounts for: " + selectedCustomer.ToString();
        }

        private void setupListView()
        {
            listViewAccountDetails.View = View.Details;
            listViewAccountDetails.FullRowSelect = true;

            // column headers
            listViewAccountDetails.Columns.Add("Account Name", 200);
            listViewAccountDetails.Columns.Add("Current Balance", 150, HorizontalAlignment.Right);
            listViewAccountDetails.Columns.Add("Credit Limit", 150, HorizontalAlignment.Right);

            // Available Funds header will fill remaining width of ListView. 
            listViewAccountDetails.Columns.Add("Available Funds", -2, HorizontalAlignment.Right);

            // user cannot reorder columns
            listViewAccountDetails.AllowColumnReorder = false;
            listViewAccountDetails.GridLines = false;

            listViewAccountDetails.Sorting = SortOrder.None;
        }

        // Adds the customers bank account details to the list view
        private void displayCustomerDetails()
        {
            listViewAccountDetails.Items.Clear();
            listViewAccountDetails.BeginUpdate();

            // used to set the pattern for negative numbers
            NumberFormatInfo myNfi = new NumberFormatInfo();
            myNfi.NumberNegativePattern = 0; 

            foreach (BankAccount account in selectedCustomer.Accounts)
            {
                ListViewItem item = listViewAccountDetails.Items.Add(account.ToString());
                item.UseItemStyleForSubItems = false;

                ListViewItem.ListViewSubItem balance = new ListViewItem.ListViewSubItem();

                balance.Text = account.AccountBalance.ToString("N2", myNfi);
                item.SubItems.Add(balance);

                if (account.AccountBalance < (decimal)0.00)
                {
                    balance.ForeColor = Color.Red;
                }

                if (account is SavingsAccount)
                {
                    item.SubItems.Add("N/A");                  
                }
                else
                {
                    LineOfCreditAccount temp = (LineOfCreditAccount)account;
                    item.SubItems.Add(temp.CreditLimit.ToString("N2"));
                }
                // display the available funds for the account
                item.SubItems.Add(account.CalculateAvailableFunds().ToString("N2"));
            }
            listViewAccountDetails.EndUpdate();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositDialog dlg = new DepositDialog();
            dlg.Customer = selectedCustomer;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // update the account information displayed 
                displayCustomerDetails();                
            }
            dlg.Dispose();
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawDialog dlg = new WithdrawDialog();
            dlg.Customer = selectedCustomer;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // update the account information displayed 
                displayCustomerDetails();
            }
            dlg.Dispose();
        }

        private void buttonTrasnferFunds_Click(object sender, EventArgs e)
        {
            TransferFundsDialog dlg = new TransferFundsDialog();
            dlg.Customer = selectedCustomer;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // update the account information displayed
                displayCustomerDetails();
            }
            dlg.Dispose();
        }

        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            // create a singleton form for transaction history
            TransactionHistoryDialog singleton = TransactionHistoryDialog.CreateForm();
            singleton.Customer = selectedCustomer;
            singleton.Show();
        }

        // Stops the user from changing the column width
        private void listViewAccountDetails_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewAccountDetails.Columns[e.ColumnIndex].Width;
        }

        // This is called every 5 seconds to process any pending transactions that
        // are older than 30 seconds and update the displayed account information
        private void timerProcessTransactions_Tick(object sender, EventArgs e)
        {
            selectedCustomer.Transactions.ProcessPendingTransactions();
            displayCustomerDetails();
        }
    }
}
