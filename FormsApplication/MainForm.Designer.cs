namespace FormsApplication
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            welcomeTxt = new Label();
            button1 = new Button();
            notifyIcon = new NotifyIcon(components);
            summaryPanel = new Panel();
            transactionStats = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            capacityLevel = new Label();
            productsBar = new ProgressBar();
            timeLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            productBindingSource = new BindingSource(components);
            lastTransactionsLabel = new Label();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeTxt.Location = new Point(18, 10);
            welcomeTxt.Margin = new Padding(5, 0, 5, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(102, 21);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "welcomeTxt";
            // 
            // button1
            // 
            button1.Location = new Point(814, 450);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(101, 30);
            button1.TabIndex = 1;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // notifyIcon
            // 
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "InventoryManagement";
            notifyIcon.Visible = true;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.Gainsboro;
            summaryPanel.Controls.Add(label1);
            summaryPanel.Controls.Add(dataGridView1);
            summaryPanel.Controls.Add(lastTransactionsLabel);
            summaryPanel.Controls.Add(transactionStats);
            summaryPanel.Controls.Add(capacityLevel);
            summaryPanel.Controls.Add(productsBar);
            summaryPanel.Controls.Add(welcomeTxt);
            summaryPanel.Location = new Point(14, 12);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(428, 462);
            summaryPanel.TabIndex = 2;
            // 
            // transactionStats
            // 
            transactionStats.AllowUserToAddRows = false;
            transactionStats.AllowUserToDeleteRows = false;
            transactionStats.AllowUserToOrderColumns = true;
            transactionStats.AutoGenerateColumns = false;
            transactionStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionStats.Columns.AddRange(new DataGridViewColumn[] { Product, TransactionType, quantityDataGridViewTextBoxColumn, TransactionDate });
            transactionStats.DataSource = transactionBindingSource;
            transactionStats.Location = new Point(3, 246);
            transactionStats.Name = "transactionStats";
            transactionStats.ReadOnly = true;
            transactionStats.Size = new Size(420, 136);
            transactionStats.TabIndex = 3;
            // 
            // Product
            // 
            Product.DataPropertyName = "Product";
            Product.HeaderText = "Продукти";
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 80;
            // 
            // TransactionType
            // 
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "Тип";
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // TransactionDate
            // 
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionDate.HeaderText = "Дата";
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(InventoryManagement.Models.Transaction);
            // 
            // capacityLevel
            // 
            capacityLevel.AutoSize = true;
            capacityLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            capacityLevel.Location = new Point(18, 398);
            capacityLevel.Margin = new Padding(5, 0, 5, 0);
            capacityLevel.Name = "capacityLevel";
            capacityLevel.Size = new Size(233, 21);
            capacityLevel.TabIndex = 2;
            capacityLevel.Text = "Използвано място в склада:";
            // 
            // productsBar
            // 
            productsBar.Location = new Point(18, 422);
            productsBar.Maximum = 1000;
            productsBar.Name = "productsBar";
            productsBar.Size = new Size(390, 23);
            productsBar.TabIndex = 1;
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(857, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(58, 17);
            timeLabel.TabIndex = 3;
            timeLabel.Text = "00:00:00";
            timeLabel.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(462, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(453, 412);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(445, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Продукти";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(445, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Категории";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(445, 384);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Транзакции";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(445, 384);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Филтри";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(445, 384);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Доставчици";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(445, 384);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Отчети";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(InventoryManagement.Models.Product);
            // 
            // lastTransactionsLabel
            // 
            lastTransactionsLabel.AutoSize = true;
            lastTransactionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lastTransactionsLabel.Location = new Point(5, 222);
            lastTransactionsLabel.Margin = new Padding(5, 0, 5, 0);
            lastTransactionsLabel.Name = "lastTransactionsLabel";
            lastTransactionsLabel.Size = new Size(185, 21);
            lastTransactionsLabel.TabIndex = 4;
            lastTransactionsLabel.Text = "Последни транзакции";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Category, Quantity, Supplier });
            dataGridView1.DataSource = productBindingSource;
            dataGridView1.Location = new Point(5, 72);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(420, 134);
            dataGridView1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 49);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 6;
            label1.Text = "Ниски наличности";
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "Продукт";
            Name.Name = "Name";
            Name.ReadOnly = true;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Категория";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Количество";
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            // 
            // Supplier
            // 
            Supplier.DataPropertyName = "Supplier";
            Supplier.HeaderText = "Доставчик";
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(927, 486);
            Controls.Add(tabControl1);
            Controls.Add(timeLabel);
            Controls.Add(summaryPanel);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventoryManagement";
            Load += MainForm_Load;
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label welcomeTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.ProgressBar productsBar;
        private Label capacityLevel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private DataGridView transactionStats;
        private BindingSource transactionBindingSource;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TransactionDate;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Supplier;
        private Label lastTransactionsLabel;
    }
}