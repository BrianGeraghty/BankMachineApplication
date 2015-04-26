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
    public partial class WithdrawDialog : Form
    {
        private Customer customer;
        private decimal amount;

        public WithdrawDialog()
        {
            InitializeComponent();
        }

        private void WithdrawDialog_Load(object sender, EventArgs e)
        {
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

        // makes the user entered a valid decimal value
        protected bool validateData()
        {
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                errorProviderWithdraw.SetError(textBoxAmount, "Invalid amount. Please enter a numeric value");
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
                    WithdrawalTransaction transaction = new WithdrawalTransaction(
                        customer, amount, comboBoxAccounts.SelectedItem as BankAccount);

                    transaction.doTransaction();
                    this.DialogResult = DialogResult.OK;
                }
                catch (InactiveAccountException ex)
                {
                    errorProviderWithdraw.SetError(comboBoxAccounts, ex.Message);
                }
                catch (InvalidAmountException ex)
                {
                    errorProviderWithdraw.SetError(textBoxAmount, ex.Message);
                }
                catch (InsufficientFundsException ex)
                {
                    errorProviderWithdraw.SetError(textBoxAmount, ex.Message);
                }
            }
        }

        // validates the value entered in textBoxAmount as user tabs out of it
        private void textBoxAmount_Validating(object sender, CancelEventArgs e)
        {
            if (validateData())
            {
                errorProviderWithdraw.SetError(textBoxAmount, String.Empty);
            }
        }
    }
}
