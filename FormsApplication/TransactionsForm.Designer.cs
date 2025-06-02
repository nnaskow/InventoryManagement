namespace FormsApplication
{
    partial class TransactionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionsForm));
            transactionListTxtBox = new TextBox();
            transactionList = new Label();
            SuspendLayout();
            // 
            // transactionListTxtBox
            // 
            transactionListTxtBox.BackColor = Color.WhiteSmoke;
            transactionListTxtBox.Location = new Point(12, 58);
            transactionListTxtBox.MaximumSize = new Size(373, 508);
            transactionListTxtBox.MinimumSize = new Size(373, 508);
            transactionListTxtBox.Multiline = true;
            transactionListTxtBox.Name = "transactionListTxtBox";
            transactionListTxtBox.ReadOnly = true;
            transactionListTxtBox.ScrollBars = ScrollBars.Vertical;
            transactionListTxtBox.Size = new Size(373, 508);
            transactionListTxtBox.TabIndex = 17;
            // 
            // transactionList
            // 
            transactionList.AutoSize = true;
            transactionList.BackColor = Color.Transparent;
            transactionList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transactionList.ForeColor = SystemColors.Control;
            transactionList.Location = new Point(12, 36);
            transactionList.Name = "transactionList";
            transactionList.Size = new Size(155, 21);
            transactionList.TabIndex = 16;
            transactionList.Text = "Лист с транзакции";
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(402, 593);
            Controls.Add(transactionListTxtBox);
            Controls.Add(transactionList);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximumSize = new Size(418, 632);
            MinimumSize = new Size(418, 632);
            Name = "TransactionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TransactionsForm";
            Load += TransactionsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox transactionListTxtBox;
        private Label transactionList;
    }
}