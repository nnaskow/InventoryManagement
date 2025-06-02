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
            transactionListTxtBox.Multiline = true;
            transactionListTxtBox.Name = "transactionListTxtBox";
            transactionListTxtBox.ReadOnly = true;
            transactionListTxtBox.ScrollBars = ScrollBars.Vertical;
            transactionListTxtBox.Size = new Size(413, 560);
            transactionListTxtBox.TabIndex = 17;
            // 
            // transactionList
            // 
            transactionList.AutoSize = true;
            transactionList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            transactionList.Location = new Point(40, 35);
            transactionList.Name = "transactionList";
            transactionList.Size = new Size(165, 23);
            transactionList.TabIndex = 16;
            transactionList.Text = "Лист с транзакции";
            // 
            // TransactionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 652);
            Controls.Add(transactionListTxtBox);
            Controls.Add(transactionList);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
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