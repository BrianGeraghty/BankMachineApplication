namespace COMP2614Assign04
{
    partial class TransferFundsDialog
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelFromAccount = new System.Windows.Forms.Label();
            this.labelToAccount = new System.Windows.Forms.Label();
            this.comboBoxFromAccount = new System.Windows.Forms.ComboBox();
            this.comboBoxToAccount = new System.Windows.Forms.ComboBox();
            this.labelAmount = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.errorProviderTransferFunds = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransferFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOk.Location = new System.Drawing.Point(243, 107);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(324, 107);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelFromAccount
            // 
            this.labelFromAccount.AutoSize = true;
            this.labelFromAccount.Location = new System.Drawing.Point(13, 13);
            this.labelFromAccount.Name = "labelFromAccount";
            this.labelFromAccount.Size = new System.Drawing.Size(73, 13);
            this.labelFromAccount.TabIndex = 4;
            this.labelFromAccount.Text = "&From Account";
            // 
            // labelToAccount
            // 
            this.labelToAccount.AutoSize = true;
            this.labelToAccount.Location = new System.Drawing.Point(207, 13);
            this.labelToAccount.Name = "labelToAccount";
            this.labelToAccount.Size = new System.Drawing.Size(63, 13);
            this.labelToAccount.TabIndex = 6;
            this.labelToAccount.Text = "&To Account";
            // 
            // comboBoxFromAccount
            // 
            this.comboBoxFromAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFromAccount.FormattingEnabled = true;
            this.comboBoxFromAccount.Location = new System.Drawing.Point(16, 30);
            this.comboBoxFromAccount.Name = "comboBoxFromAccount";
            this.comboBoxFromAccount.Size = new System.Drawing.Size(160, 21);
            this.comboBoxFromAccount.TabIndex = 5;
            this.comboBoxFromAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxFromAccount_SelectedIndexChanged);
            // 
            // comboBoxToAccount
            // 
            this.comboBoxToAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxToAccount.FormattingEnabled = true;
            this.comboBoxToAccount.Location = new System.Drawing.Point(210, 30);
            this.comboBoxToAccount.Name = "comboBoxToAccount";
            this.comboBoxToAccount.Size = new System.Drawing.Size(160, 21);
            this.comboBoxToAccount.TabIndex = 7;
            this.comboBoxToAccount.SelectedIndexChanged += new System.EventHandler(this.comboBoxToAccount_SelectedIndexChanged);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(16, 67);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(43, 13);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "&Amount";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(19, 83);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(103, 20);
            this.textBoxAmount.TabIndex = 1;
            this.textBoxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxAmount.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAmount_Validating);
            // 
            // errorProviderTransferFunds
            // 
            this.errorProviderTransferFunds.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderTransferFunds.ContainerControl = this;
            // 
            // TransferFundsDialog
            // 
            this.AcceptButton = this.buttonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(414, 142);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.comboBoxToAccount);
            this.Controls.Add(this.comboBoxFromAccount);
            this.Controls.Add(this.labelToAccount);
            this.Controls.Add(this.labelFromAccount);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferFundsDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Transfer Funds";
            this.Load += new System.EventHandler(this.TransferFundsDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTransferFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelFromAccount;
        private System.Windows.Forms.Label labelToAccount;
        private System.Windows.Forms.ComboBox comboBoxFromAccount;
        private System.Windows.Forms.ComboBox comboBoxToAccount;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ErrorProvider errorProviderTransferFunds;
    }
}