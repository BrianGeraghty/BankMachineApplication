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
    public partial class TransferFundsDialog : Form
    {
        private Customer customer;
        private Decimal amount;

        public TransferFundsDialog()
        {
            InitializeComponent();
        }

        private void TransferFundsDialog_Load(object sender, EventArgs e)
        {
            // populate comboBoxFromAccount with all 3 customer accounts
            comboBoxFromAccount.DataSource = Customer.Accounts.ToList();
            // populate ComboBoxToAccount with 2 accounts not selected in comboBoxFromAccount
            updateToAccountList();
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public Decimal Amount
        {
            get { return amount; }
        }

        private void comboBoxFromAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateToAccountList();
            textBoxAmount.Focus();
        }

        // updates comboBoxToAccount with the accounts not selected in comboBoxFromAccount
        private void updateToAccountList()
        {
            BankAccountCollection toAccounts = new BankAccountCollection();

            foreach (BankAccount account in Customer.Accounts)
            {
                if (account != comboBoxFromAccount.SelectedItem as BankAccount)
                {
                    toAccounts.Add(account);
                }
            }
            comboBoxToAccount.DataSource = toAccounts.ToList();
        }

        private void comboBoxToAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAmount.Focus();
        }

        // checks the the user has entered a valid decimal amount
        protected bool validateData()
        {
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                errorProviderTransferFunds.SetError(textBoxAmount, "Invalid amount. Please enter a numeric value");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (validateData())
            {
                try
                {
                    TransferFundsTransaction transaction = new TransferFundsTransaction(
                        customer, amount, comboBoxFromAccount.SelectedItem as BankAccount,
                        comboBoxToAccount.SelectedItem as BankAccount);

                    transaction.doTransaction();

                    this.DialogResult = DialogResult.OK;
                }
                catch (TransferFundsException ex)
                {
                    // user has selected the same To and From accounts so display
                    // errorProvider beside both to and from combo boxes
                    errorProviderTransferFunds.SetError(comboBoxFromAccount, ex.Message);
                    errorProviderTransferFunds.SetError(comboBoxToAccount, ex.Message);
                }
                catch (InactiveAccountException ex)
                {
                    // check to see which account is inactive and display error provider
                    // beside the relevant account
                    if(ex.Account.ToString() == comboBoxFromAccount.SelectedItem.ToString())
                    {
                        errorProviderTransferFunds.SetError(comboBoxFromAccount, ex.Message);
                    }
                    else
                    {
                        errorProviderTransferFunds.SetError(comboBoxToAccount, ex.Message);
                    }
                }
                catch (InvalidAmountException ex)
                {
                    errorProviderTransferFunds.SetError(textBoxAmount, ex.Message);
                }
                catch (InsufficientFundsException ex)
                {
                    errorProviderTransferFunds.SetError(textBoxAmount, ex.Message);
                }
            }
        }

        // validates the data when tabbing away from textBoxAmount
        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (validateData())
            {
                errorProviderTransferFunds.SetError(textBoxAmount, String.Empty);
            }
        }
    }
}
