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
    public partial class DepositDialog : Form
    {
        private Customer customer;
        private decimal amount;

        public DepositDialog()
        {
            InitializeComponent();
        }

        private void DepositDialog_Load(object sender, EventArgs e)
        {
            // populate comboBoxAccounts with the customers accounts
            comboBoxAccounts.DataSource = Customer.Accounts.ToList();
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public decimal Amount
        {
            get { return amount; }
        }

        // Checks if a decimal value has been entered by the user
        protected bool validateData()
        {            
            if (!decimal.TryParse(textBoxAmount.Text, out amount))       
            {
                errorProviderDeposit.SetError(textBoxAmount, "Invalid amount. Please enter a numeric value");
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
                    DepositTransaction transaction = new DepositTransaction(Customer, amount,
                        comboBoxAccounts.SelectedItem as BankAccount);

                    transaction.doTransaction();
                    this.DialogResult = DialogResult.OK;
                }
                catch (InactiveAccountException ex)
                {
                    // account is inactive
                    errorProviderDeposit.SetError(comboBoxAccounts, ex.Message);
                }
                catch (InvalidAmountException ex)
                {
                    // amount entered is invalid
                    errorProviderDeposit.SetError(textBoxAmount, ex.Message);
                }
            }
        }

        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (validateData())
            {
                // clear the errorProvider if the amount entered is valid
                errorProviderDeposit.SetError(textBoxAmount, String.Empty);
            }
        }
    }
}
