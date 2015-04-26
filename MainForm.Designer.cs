namespace COMP2614Assign04
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listViewAccountDetails = new System.Windows.Forms.ListView();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.buttonWithdraw = new System.Windows.Forms.Button();
            this.buttonTrasnferFunds = new System.Windows.Forms.Button();
            this.buttonTransactionHistory = new System.Windows.Forms.Button();
            this.timerProcessTransactions = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listViewAccountDetails
            // 
            this.listViewAccountDetails.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAccountDetails.Location = new System.Drawing.Point(12, 12);
            this.listViewAccountDetails.MultiSelect = false;
            this.listViewAccountDetails.Name = "listViewAccountDetails";
            this.listViewAccountDetails.Size = new System.Drawing.Size(649, 101);
            this.listViewAccountDetails.TabIndex = 0;
            this.listViewAccountDetails.UseCompatibleStateImageBehavior = false;
            this.listViewAccountDetails.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listViewAccountDetails_ColumnWidthChanging);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(12, 127);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(190, 30);
            this.buttonDeposit.TabIndex = 1;
            this.buttonDeposit.Text = "&Deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // buttonWithdraw
            // 
            this.buttonWithdraw.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdraw.Location = new System.Drawing.Point(237, 127);
            this.buttonWithdraw.Name = "buttonWithdraw";
            this.buttonWithdraw.Size = new System.Drawing.Size(190, 30);
            this.buttonWithdraw.TabIndex = 2;
            this.buttonWithdraw.Text = "&Withdraw";
            this.buttonWithdraw.UseVisualStyleBackColor = true;
            this.buttonWithdraw.Click += new System.EventHandler(this.buttonWithdraw_Click);
            // 
            // buttonTrasnferFunds
            // 
            this.buttonTrasnferFunds.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTrasnferFunds.Location = new System.Drawing.Point(471, 127);
            this.buttonTrasnferFunds.Name = "buttonTrasnferFunds";
            this.buttonTrasnferFunds.Size = new System.Drawing.Size(190, 30);
            this.buttonTrasnferFunds.TabIndex = 3;
            this.buttonTrasnferFunds.Text = "&Transfer Funds";
            this.buttonTrasnferFunds.UseVisualStyleBackColor = true;
            this.buttonTrasnferFunds.Click += new System.EventHandler(this.buttonTrasnferFunds_Click);
            // 
            // buttonTransactionHistory
            // 
            this.buttonTransactionHistory.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransactionHistory.Location = new System.Drawing.Point(471, 190);
            this.buttonTransactionHistory.Name = "buttonTransactionHistory";
            this.buttonTransactionHistory.Size = new System.Drawing.Size(190, 30);
            this.buttonTransactionHistory.TabIndex = 4;
            this.buttonTransactionHistory.Text = "Transaction &History";
            this.buttonTransactionHistory.UseVisualStyleBackColor = true;
            this.buttonTransactionHistory.Click += new System.EventHandler(this.buttonTransactionHistory_Click);
            // 
            // timerProcessTransactions
            // 
            this.timerProcessTransactions.Enabled = true;
            this.timerProcessTransactions.Interval = 5000;
            this.timerProcessTransactions.Tick += new System.EventHandler(this.timerProcessTransactions_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 235);
            this.Controls.Add(this.buttonTransactionHistory);
            this.Controls.Add(this.buttonTrasnferFunds);
            this.Controls.Add(this.buttonWithdraw);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.listViewAccountDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts for:";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAccountDetails;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.Button buttonWithdraw;
        private System.Windows.Forms.Button buttonTrasnferFunds;
        private System.Windows.Forms.Button buttonTransactionHistory;
        private System.Windows.Forms.Timer timerProcessTransactions;
    }
}

