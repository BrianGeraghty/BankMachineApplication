namespace COMP2614Assign04
{
    partial class TransactionHistoryDialog
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
            this.checkBoxShowDetails = new System.Windows.Forms.CheckBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.richTextBoxTransactionHistory = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // checkBoxShowDetails
            // 
            this.checkBoxShowDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxShowDetails.AutoSize = true;
            this.checkBoxShowDetails.Location = new System.Drawing.Point(12, 462);
            this.checkBoxShowDetails.Name = "checkBoxShowDetails";
            this.checkBoxShowDetails.Size = new System.Drawing.Size(88, 17);
            this.checkBoxShowDetails.TabIndex = 3;
            this.checkBoxShowDetails.Text = "Show &Details";
            this.checkBoxShowDetails.UseVisualStyleBackColor = true;
            this.checkBoxShowDetails.CheckedChanged += new System.EventHandler(this.checkBoxShowDetails_CheckedChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(235, 479);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // richTextBoxTransactionHistory
            // 
            this.richTextBoxTransactionHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTransactionHistory.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxTransactionHistory.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxTransactionHistory.Location = new System.Drawing.Point(0, 1);
            this.richTextBoxTransactionHistory.Name = "richTextBoxTransactionHistory";
            this.richTextBoxTransactionHistory.ReadOnly = true;
            this.richTextBoxTransactionHistory.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxTransactionHistory.Size = new System.Drawing.Size(322, 438);
            this.richTextBoxTransactionHistory.TabIndex = 7;
            this.richTextBoxTransactionHistory.Text = "";
            // 
            // TransactionHistoryDialog
            // 
            this.AcceptButton = this.buttonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClose;
            this.ClientSize = new System.Drawing.Size(322, 511);
            this.Controls.Add(this.richTextBoxTransactionHistory);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.checkBoxShowDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransactionHistoryDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction History";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TransactionHistoryDialog_FormClosing);
            this.Load += new System.EventHandler(this.TransactionHistoryDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowDetails;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.RichTextBox richTextBoxTransactionHistory;
    }
}