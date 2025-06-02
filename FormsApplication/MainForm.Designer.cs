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
            txtBoxShowList = new TextBox();
            availabilityList = new Label();
            label1 = new Label();
            lowStockGrid = new DataGridView();
            productName = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Supplier = new DataGridViewTextBoxColumn();
            productBindingSource = new BindingSource(components);
            lastTransactionsLabel = new Label();
            transactionStats = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            TransactionType = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TransactionDate = new DataGridViewTextBoxColumn();
            transactionBindingSource = new BindingSource(components);
            capacityLevel = new Label();
            productsBar = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            timeLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            newSupplierEditPr = new ComboBox();
            newCatEditPr = new ComboBox();
            SupplierComboBox = new ComboBox();
            categoryComboBox = new ComboBox();
            DeletePrButton = new Button();
            prodIDDelProd = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            EditPrButton = new Button();
            newDateEditPr = new DateTimePicker();
            label19 = new Label();
            addProductButton = new Button();
            newPriceEditPr = new TextBox();
            label17 = new Label();
            newQuantityEditPr = new TextBox();
            label18 = new Label();
            label13 = new Label();
            label14 = new Label();
            newNameEditPr = new TextBox();
            label15 = new Label();
            prIDEditProd = new TextBox();
            label16 = new Label();
            label12 = new Label();
            label11 = new Label();
            lastUpdateDTPicker = new DateTimePicker();
            label9 = new Label();
            priceTextBox = new TextBox();
            label10 = new Label();
            label7 = new Label();
            QuantityTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            productNameTxtBox = new TextBox();
            productNameLabel = new Label();
            label8 = new Label();
            tabPage2 = new TabPage();
            catIDDelCat = new ComboBox();
            CatIDEditCat = new ComboBox();
            button2 = new Button();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            button3 = new Button();
            button4 = new Button();
            newNameEditCat = new TextBox();
            label31 = new Label();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label37 = new Label();
            CatNameAddCat = new TextBox();
            label41 = new Label();
            label42 = new Label();
            tabPage3 = new TabPage();
            prodIDAddTr = new ComboBox();
            transTypeAddTr = new ComboBox();
            label40 = new Label();
            dateAddTr = new DateTimePicker();
            quantityAddTr = new TextBox();
            label39 = new Label();
            label38 = new Label();
            button6 = new Button();
            label30 = new Label();
            label35 = new Label();
            label36 = new Label();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lowStockGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionStats).BeginInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // welcomeTxt
            // 
            welcomeTxt.AutoSize = true;
            welcomeTxt.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            welcomeTxt.Location = new Point(18, 10);
            welcomeTxt.Margin = new Padding(5, 0, 5, 0);
            welcomeTxt.Name = "welcomeTxt";
            welcomeTxt.Size = new Size(126, 28);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "welcomeTxt";
            // 
            // button1
            // 
            button1.Location = new Point(993, 618);
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
            summaryPanel.Controls.Add(txtBoxShowList);
            summaryPanel.Controls.Add(availabilityList);
            summaryPanel.Controls.Add(label1);
            summaryPanel.Controls.Add(lowStockGrid);
            summaryPanel.Controls.Add(lastTransactionsLabel);
            summaryPanel.Controls.Add(transactionStats);
            summaryPanel.Controls.Add(capacityLevel);
            summaryPanel.Controls.Add(productsBar);
            summaryPanel.Controls.Add(welcomeTxt);
            summaryPanel.Controls.Add(label2);
            summaryPanel.Controls.Add(label3);
            summaryPanel.Location = new Point(14, 12);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(440, 636);
            summaryPanel.TabIndex = 2;
            // 
            // txtBoxShowList
            // 
            txtBoxShowList.BackColor = Color.WhiteSmoke;
            txtBoxShowList.Location = new Point(5, 88);
            txtBoxShowList.Multiline = true;
            txtBoxShowList.Name = "txtBoxShowList";
            txtBoxShowList.ReadOnly = true;
            txtBoxShowList.ScrollBars = ScrollBars.Vertical;
            txtBoxShowList.Size = new Size(412, 133);
            txtBoxShowList.TabIndex = 1;
            // 
            // availabilityList
            // 
            availabilityList.AutoSize = true;
            availabilityList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            availabilityList.Location = new Point(5, 62);
            availabilityList.Margin = new Padding(5, 0, 5, 0);
            availabilityList.Name = "availabilityList";
            availabilityList.Size = new Size(186, 23);
            availabilityList.TabIndex = 9;
            availabilityList.Text = "Списък с наличности";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 221);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(165, 23);
            label1.TabIndex = 6;
            label1.Text = "Ниски наличности";
            // 
            // lowStockGrid
            // 
            lowStockGrid.AllowUserToAddRows = false;
            lowStockGrid.AllowUserToDeleteRows = false;
            lowStockGrid.AllowUserToOrderColumns = true;
            lowStockGrid.AutoGenerateColumns = false;
            lowStockGrid.BackgroundColor = Color.WhiteSmoke;
            lowStockGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lowStockGrid.Columns.AddRange(new DataGridViewColumn[] { productName, Category, Quantity, Supplier });
            lowStockGrid.DataSource = productBindingSource;
            lowStockGrid.Location = new Point(5, 247);
            lowStockGrid.Name = "lowStockGrid";
            lowStockGrid.ReadOnly = true;
            lowStockGrid.RowHeadersWidth = 51;
            lowStockGrid.Size = new Size(420, 134);
            lowStockGrid.TabIndex = 5;
            // 
            // productName
            // 
            productName.DataPropertyName = "Name";
            productName.HeaderText = "Продукт";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Width = 125;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "Категория";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.ReadOnly = true;
            Category.Width = 125;
            // 
            // Quantity
            // 
            Quantity.DataPropertyName = "Quantity";
            Quantity.HeaderText = "Количество";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 125;
            // 
            // Supplier
            // 
            Supplier.DataPropertyName = "Supplier";
            Supplier.HeaderText = "Доставчик";
            Supplier.MinimumWidth = 6;
            Supplier.Name = "Supplier";
            Supplier.ReadOnly = true;
            Supplier.Width = 125;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(InventoryManagement.Models.Product);
            // 
            // lastTransactionsLabel
            // 
            lastTransactionsLabel.AutoSize = true;
            lastTransactionsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lastTransactionsLabel.Location = new Point(5, 384);
            lastTransactionsLabel.Margin = new Padding(5, 0, 5, 0);
            lastTransactionsLabel.Name = "lastTransactionsLabel";
            lastTransactionsLabel.Size = new Size(195, 23);
            lastTransactionsLabel.TabIndex = 4;
            lastTransactionsLabel.Text = "Последни транзакции";
            // 
            // transactionStats
            // 
            transactionStats.AllowUserToAddRows = false;
            transactionStats.AllowUserToDeleteRows = false;
            transactionStats.AllowUserToOrderColumns = true;
            transactionStats.AutoGenerateColumns = false;
            transactionStats.BackgroundColor = Color.WhiteSmoke;
            transactionStats.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionStats.Columns.AddRange(new DataGridViewColumn[] { Product, TransactionType, quantityDataGridViewTextBoxColumn, TransactionDate });
            transactionStats.DataSource = transactionBindingSource;
            transactionStats.Location = new Point(5, 408);
            transactionStats.Name = "transactionStats";
            transactionStats.ReadOnly = true;
            transactionStats.RowHeadersWidth = 51;
            transactionStats.Size = new Size(420, 136);
            transactionStats.TabIndex = 3;
            // 
            // Product
            // 
            Product.DataPropertyName = "Product";
            Product.HeaderText = "Продукт";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 80;
            // 
            // TransactionType
            // 
            TransactionType.DataPropertyName = "TransactionType";
            TransactionType.HeaderText = "Тип";
            TransactionType.MinimumWidth = 6;
            TransactionType.Name = "TransactionType";
            TransactionType.ReadOnly = true;
            TransactionType.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Количество";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // TransactionDate
            // 
            TransactionDate.DataPropertyName = "TransactionDate";
            TransactionDate.HeaderText = "Дата";
            TransactionDate.MinimumWidth = 6;
            TransactionDate.Name = "TransactionDate";
            TransactionDate.ReadOnly = true;
            TransactionDate.Width = 125;
            // 
            // transactionBindingSource
            // 
            transactionBindingSource.DataSource = typeof(InventoryManagement.Models.Transaction);
            // 
            // capacityLevel
            // 
            capacityLevel.AutoSize = true;
            capacityLevel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            capacityLevel.Location = new Point(18, 571);
            capacityLevel.Margin = new Padding(5, 0, 5, 0);
            capacityLevel.Name = "capacityLevel";
            capacityLevel.Size = new Size(291, 28);
            capacityLevel.TabIndex = 2;
            capacityLevel.Text = "Използвано място в склада:";
            // 
            // productsBar
            // 
            productsBar.Location = new Point(18, 595);
            productsBar.Maximum = 1000;
            productsBar.Name = "productsBar";
            productsBar.Size = new Size(390, 23);
            productsBar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(13, 26);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(460, 28);
            label2.TabIndex = 7;
            label2.Text = "________________________________________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(3, 539);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(460, 28);
            label3.TabIndex = 8;
            label3.Text = "________________________________________________________";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(1036, 12);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(80, 23);
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
            tabControl1.Location = new Point(460, 39);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(638, 567);
            tabControl1.TabIndex = 4;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(newSupplierEditPr);
            tabPage1.Controls.Add(newCatEditPr);
            tabPage1.Controls.Add(SupplierComboBox);
            tabPage1.Controls.Add(categoryComboBox);
            tabPage1.Controls.Add(DeletePrButton);
            tabPage1.Controls.Add(prodIDDelProd);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(EditPrButton);
            tabPage1.Controls.Add(newDateEditPr);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(addProductButton);
            tabPage1.Controls.Add(newPriceEditPr);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(newQuantityEditPr);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(newNameEditPr);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(prIDEditProd);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(lastUpdateDTPicker);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(priceTextBox);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(QuantityTextBox);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(productNameTxtBox);
            tabPage1.Controls.Add(productNameLabel);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(630, 533);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Продукти";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // newSupplierEditPr
            // 
            newSupplierEditPr.FormattingEnabled = true;
            newSupplierEditPr.Location = new Point(221, 273);
            newSupplierEditPr.Name = "newSupplierEditPr";
            newSupplierEditPr.Size = new Size(171, 29);
            newSupplierEditPr.TabIndex = 40;
            newSupplierEditPr.MouseClick += newSupplierEditPr_MouseClick;
            // 
            // newCatEditPr
            // 
            newCatEditPr.FormattingEnabled = true;
            newCatEditPr.Location = new Point(221, 212);
            newCatEditPr.Name = "newCatEditPr";
            newCatEditPr.Size = new Size(171, 29);
            newCatEditPr.TabIndex = 39;
            newCatEditPr.MouseClick += newCatEditPr_MouseClick;
            // 
            // SupplierComboBox
            // 
            SupplierComboBox.FormattingEnabled = true;
            SupplierComboBox.Location = new Point(21, 212);
            SupplierComboBox.Name = "SupplierComboBox";
            SupplierComboBox.Size = new Size(171, 29);
            SupplierComboBox.TabIndex = 38;
            SupplierComboBox.MouseClick += SupplierComboBox_MouseClick;
            // 
            // categoryComboBox
            // 
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(21, 152);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(171, 29);
            categoryComboBox.TabIndex = 37;
            categoryComboBox.Click += categoryComboBox_Click;
            // 
            // DeletePrButton
            // 
            DeletePrButton.Location = new Point(447, 168);
            DeletePrButton.Margin = new Padding(5, 4, 5, 4);
            DeletePrButton.Name = "DeletePrButton";
            DeletePrButton.Size = new Size(111, 30);
            DeletePrButton.TabIndex = 36;
            DeletePrButton.Text = "Изтриване";
            DeletePrButton.UseVisualStyleBackColor = true;
            // 
            // prodIDDelProd
            // 
            prodIDDelProd.Location = new Point(416, 135);
            prodIDDelProd.Name = "prodIDDelProd";
            prodIDDelProd.Size = new Size(171, 29);
            prodIDDelProd.TabIndex = 35;
            prodIDDelProd.MouseClick += prodIDDelProd_MouseClick;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(416, 115);
            label20.Name = "label20";
            label20.Size = new Size(126, 23);
            label20.TabIndex = 34;
            label20.Text = "ID на продукт";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(416, 73);
            label21.Name = "label21";
            label21.Size = new Size(197, 23);
            label21.TabIndex = 33;
            label21.Text = "Изтриване на продукт";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(416, 90);
            label22.Name = "label22";
            label22.Size = new Size(199, 23);
            label22.TabIndex = 32;
            label22.Text = "___________________________";
            // 
            // EditPrButton
            // 
            EditPrButton.Location = new Point(235, 476);
            EditPrButton.Margin = new Padding(5, 4, 5, 4);
            EditPrButton.Name = "EditPrButton";
            EditPrButton.Size = new Size(140, 30);
            EditPrButton.TabIndex = 31;
            EditPrButton.Text = "Редактиране";
            EditPrButton.UseVisualStyleBackColor = true;
            // 
            // newDateEditPr
            // 
            newDateEditPr.Location = new Point(221, 440);
            newDateEditPr.Name = "newDateEditPr";
            newDateEditPr.Size = new Size(171, 29);
            newDateEditPr.TabIndex = 30;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(221, 420);
            label19.Name = "label19";
            label19.Size = new Size(99, 23);
            label19.TabIndex = 29;
            label19.Text = "Нова дата ";
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(44, 414);
            addProductButton.Margin = new Padding(5, 4, 5, 4);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(101, 30);
            addProductButton.TabIndex = 5;
            addProductButton.Text = "Добавяне";
            addProductButton.UseVisualStyleBackColor = true;
            // 
            // newPriceEditPr
            // 
            newPriceEditPr.Location = new Point(221, 385);
            newPriceEditPr.Name = "newPriceEditPr";
            newPriceEditPr.Size = new Size(171, 29);
            newPriceEditPr.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(221, 365);
            label17.Name = "label17";
            label17.Size = new Size(96, 23);
            label17.TabIndex = 27;
            label17.Text = "Нова цена";
            // 
            // newQuantityEditPr
            // 
            newQuantityEditPr.Location = new Point(221, 325);
            newQuantityEditPr.Name = "newQuantityEditPr";
            newQuantityEditPr.Size = new Size(171, 29);
            newQuantityEditPr.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(221, 305);
            label18.Name = "label18";
            label18.Size = new Size(154, 23);
            label18.TabIndex = 25;
            label18.Text = "Ново количество";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(221, 244);
            label13.Name = "label13";
            label13.Size = new Size(135, 23);
            label13.TabIndex = 23;
            label13.Text = "Нов доставчик";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(221, 184);
            label14.Name = "label14";
            label14.Size = new Size(142, 23);
            label14.TabIndex = 21;
            label14.Text = "Нова категория";
            // 
            // newNameEditPr
            // 
            newNameEditPr.Location = new Point(221, 145);
            newNameEditPr.Name = "newNameEditPr";
            newNameEditPr.Size = new Size(171, 29);
            newNameEditPr.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(221, 125);
            label15.Name = "label15";
            label15.Size = new Size(189, 23);
            label15.TabIndex = 19;
            label15.Text = "Ново име на продукт";
            // 
            // prIDEditProd
            // 
            prIDEditProd.Location = new Point(221, 85);
            prIDEditProd.Name = "prIDEditProd";
            prIDEditProd.Size = new Size(171, 29);
            prIDEditProd.TabIndex = 18;
            prIDEditProd.MouseClick += prIDEditProd_MouseClick;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(221, 65);
            label16.Name = "label16";
            label16.Size = new Size(126, 23);
            label16.TabIndex = 17;
            label16.Text = "ID на продукт";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(221, 23);
            label12.Name = "label12";
            label12.Size = new Size(214, 23);
            label12.TabIndex = 16;
            label12.Text = "Редактиране на продукт";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(221, 40);
            label11.Name = "label11";
            label11.Size = new Size(199, 23);
            label11.TabIndex = 15;
            label11.Text = "___________________________";
            // 
            // lastUpdateDTPicker
            // 
            lastUpdateDTPicker.Location = new Point(21, 382);
            lastUpdateDTPicker.Name = "lastUpdateDTPicker";
            lastUpdateDTPicker.Size = new Size(171, 29);
            lastUpdateDTPicker.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 356);
            label9.Name = "label9";
            label9.Size = new Size(210, 23);
            label9.TabIndex = 12;
            label9.Text = "Последна актуализация";
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(21, 322);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(171, 29);
            priceTextBox.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 302);
            label10.Name = "label10";
            label10.Size = new Size(52, 23);
            label10.TabIndex = 10;
            label10.Text = "Цена";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 23);
            label7.Name = "label7";
            label7.Size = new Size(189, 23);
            label7.TabIndex = 8;
            label7.Text = "Добавяне на продукт";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(21, 264);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(171, 29);
            QuantityTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 244);
            label5.Name = "label5";
            label5.Size = new Size(107, 23);
            label5.TabIndex = 6;
            label5.Text = "Количество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 184);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 4;
            label6.Text = "Доставчик";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 125);
            label4.Name = "label4";
            label4.Size = new Size(96, 23);
            label4.TabIndex = 2;
            label4.Text = "Категория";
            // 
            // productNameTxtBox
            // 
            productNameTxtBox.Location = new Point(21, 85);
            productNameTxtBox.Name = "productNameTxtBox";
            productNameTxtBox.Size = new Size(171, 29);
            productNameTxtBox.TabIndex = 1;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(21, 65);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(143, 23);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Име на продукт";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 40);
            label8.Name = "label8";
            label8.Size = new Size(199, 23);
            label8.TabIndex = 9;
            label8.Text = "___________________________";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(catIDDelCat);
            tabPage2.Controls.Add(CatIDEditCat);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(newNameEditCat);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(label32);
            tabPage2.Controls.Add(label33);
            tabPage2.Controls.Add(label34);
            tabPage2.Controls.Add(label37);
            tabPage2.Controls.Add(CatNameAddCat);
            tabPage2.Controls.Add(label41);
            tabPage2.Controls.Add(label42);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(630, 534);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Категории";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // catIDDelCat
            // 
            catIDDelCat.FormattingEnabled = true;
            catIDDelCat.Location = new Point(411, 97);
            catIDDelCat.Name = "catIDDelCat";
            catIDDelCat.Size = new Size(171, 29);
            catIDDelCat.TabIndex = 75;
            catIDDelCat.MouseClick += catIDDelCat_MouseClick;
            // 
            // CatIDEditCat
            // 
            CatIDEditCat.FormattingEnabled = true;
            CatIDEditCat.Location = new Point(213, 220);
            CatIDEditCat.Name = "CatIDEditCat";
            CatIDEditCat.Size = new Size(171, 29);
            CatIDEditCat.TabIndex = 74;
            CatIDEditCat.MouseClick += CatIDEditCat_MouseClick;
            // 
            // button2
            // 
            button2.Location = new Point(442, 124);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(111, 30);
            button2.TabIndex = 73;
            button2.Text = "Изтриване";
            button2.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(411, 71);
            label23.Name = "label23";
            label23.Size = new Size(142, 23);
            label23.TabIndex = 71;
            label23.Text = "ID на категория";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(411, 29);
            label24.Name = "label24";
            label24.Size = new Size(213, 23);
            label24.TabIndex = 70;
            label24.Text = "Изтриване на категория";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(411, 46);
            label25.Name = "label25";
            label25.Size = new Size(199, 23);
            label25.TabIndex = 69;
            label25.Text = "___________________________";
            // 
            // button3
            // 
            button3.Location = new Point(238, 310);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(129, 30);
            button3.TabIndex = 68;
            button3.Text = "Редактиране";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(58, 129);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(101, 30);
            button4.TabIndex = 43;
            button4.Text = "Добавяне";
            button4.UseVisualStyleBackColor = true;
            // 
            // newNameEditCat
            // 
            newNameEditCat.Location = new Point(213, 274);
            newNameEditCat.Name = "newNameEditCat";
            newNameEditCat.Size = new Size(171, 29);
            newNameEditCat.TabIndex = 57;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(213, 254);
            label31.Name = "label31";
            label31.Size = new Size(205, 23);
            label31.TabIndex = 56;
            label31.Text = "Ново име на категория";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(213, 194);
            label32.Name = "label32";
            label32.Size = new Size(142, 23);
            label32.TabIndex = 54;
            label32.Text = "ID на категория";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(198, 152);
            label33.Name = "label33";
            label33.Size = new Size(230, 23);
            label33.TabIndex = 53;
            label33.Text = "Редактиране на категория";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(198, 169);
            label34.Name = "label34";
            label34.Size = new Size(199, 23);
            label34.TabIndex = 52;
            label34.Text = "___________________________";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(29, 35);
            label37.Name = "label37";
            label37.Size = new Size(205, 23);
            label37.TabIndex = 46;
            label37.Text = "Добавяне на категория";
            // 
            // CatNameAddCat
            // 
            CatNameAddCat.Location = new Point(29, 97);
            CatNameAddCat.Name = "CatNameAddCat";
            CatNameAddCat.Size = new Size(171, 29);
            CatNameAddCat.TabIndex = 38;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(29, 77);
            label41.Name = "label41";
            label41.Size = new Size(159, 23);
            label41.TabIndex = 37;
            label41.Text = "Име на категория";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(29, 52);
            label42.Name = "label42";
            label42.Size = new Size(199, 23);
            label42.TabIndex = 47;
            label42.Text = "___________________________";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(prodIDAddTr);
            tabPage3.Controls.Add(transTypeAddTr);
            tabPage3.Controls.Add(label40);
            tabPage3.Controls.Add(dateAddTr);
            tabPage3.Controls.Add(quantityAddTr);
            tabPage3.Controls.Add(label39);
            tabPage3.Controls.Add(label38);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(label35);
            tabPage3.Controls.Add(label36);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(630, 533);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Транзакции";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // prodIDAddTr
            // 
            prodIDAddTr.FormattingEnabled = true;
            prodIDAddTr.Location = new Point(28, 99);
            prodIDAddTr.Name = "prodIDAddTr";
            prodIDAddTr.Size = new Size(171, 29);
            prodIDAddTr.TabIndex = 88;
            prodIDAddTr.MouseClick += prodIDAddTr_MouseClick;
            // 
            // transTypeAddTr
            // 
            transTypeAddTr.FormattingEnabled = true;
            transTypeAddTr.Items.AddRange(new object[] { "Входяща", "Изходяща" });
            transTypeAddTr.Location = new Point(28, 160);
            transTypeAddTr.Name = "transTypeAddTr";
            transTypeAddTr.Size = new Size(171, 29);
            transTypeAddTr.TabIndex = 87;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(28, 247);
            label40.Name = "label40";
            label40.Size = new Size(49, 23);
            label40.TabIndex = 86;
            label40.Text = "Дата";
            // 
            // dateAddTr
            // 
            dateAddTr.Location = new Point(28, 273);
            dateAddTr.Name = "dateAddTr";
            dateAddTr.Size = new Size(171, 29);
            dateAddTr.TabIndex = 85;
            // 
            // quantityAddTr
            // 
            quantityAddTr.Location = new Point(28, 208);
            quantityAddTr.Name = "quantityAddTr";
            quantityAddTr.Size = new Size(171, 29);
            quantityAddTr.TabIndex = 84;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(28, 188);
            label39.Name = "label39";
            label39.Size = new Size(107, 23);
            label39.TabIndex = 83;
            label39.Text = "Количество";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(28, 133);
            label38.Name = "label38";
            label38.Size = new Size(183, 23);
            label38.TabIndex = 81;
            label38.Text = "Тип на транзакцията";
            // 
            // button6
            // 
            button6.Location = new Point(44, 305);
            button6.Margin = new Padding(5, 4, 5, 4);
            button6.Name = "button6";
            button6.Size = new Size(101, 30);
            button6.TabIndex = 71;
            button6.Text = "Добавяне";
            button6.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(28, 31);
            label30.Name = "label30";
            label30.Size = new Size(217, 23);
            label30.TabIndex = 72;
            label30.Text = "Добавяне на транзакция";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(28, 73);
            label35.Name = "label35";
            label35.Size = new Size(126, 23);
            label35.TabIndex = 69;
            label35.Text = "ID на продукт";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(28, 48);
            label36.Name = "label36";
            label36.Size = new Size(199, 23);
            label36.TabIndex = 73;
            label36.Text = "___________________________";
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(630, 534);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Филтриране";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(630, 534);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Доставчици";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 29);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(630, 534);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Отчети";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1110, 661);
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
            ((System.ComponentModel.ISupportInitialize)lowStockGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionStats).EndInit();
            ((System.ComponentModel.ISupportInitialize)transactionBindingSource).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private Label label1;
        private DataGridView lowStockGrid;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Supplier;
        private Label lastTransactionsLabel;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn TransactionType;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn TransactionDate;
        private Label label2;
        private Label label3;
        private Label productNameLabel;
        private TextBox productNameTxtBox;
        private TextBox QuantityTextBox;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label availabilityList;
        private Label label12;
        private Label label11;
        private DateTimePicker lastUpdateDTPicker;
        private Label label9;
        private TextBox priceTextBox;
        private Label label10;
        private Label label13;
        private Label label14;
        private TextBox newNameEditPr;
        private Label label15;
        private TextBox prIDEditProd;
        private Label label16;
        private Button EditPrButton;
        private DateTimePicker newDateEditPr;
        private Label label19;
        private Button addProductButton;
        private TextBox newPriceEditPr;
        private Label label17;
        private TextBox newQuantityEditPr;
        private Label label18;
        private TextBox prodIDDelProd;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button DeletePrButton;
        private Button button2;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button button3;
        private Button button4;
        private TextBox newNameEditCat;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label37;
        private TextBox CatNameAddCat;
        private Label label41;
        private Label label42;
        private Button button6;
        private Label label30;
        private Label label35;
        private Label label36;
        private TextBox quantityAddTr;
        private Label label39;
        private Label label38;
        private TextBox txtBoxShowList;
        private Label label40;
        private DateTimePicker dateAddTr;
        private ComboBox transTypeAddTr;
        private ComboBox newSupplierEditPr;
        private ComboBox newCatEditPr;
        private ComboBox SupplierComboBox;
        private ComboBox categoryComboBox;
        private ComboBox catIDDelCat;
        private ComboBox CatIDEditCat;
        private ComboBox prodIDAddTr;
    }
}