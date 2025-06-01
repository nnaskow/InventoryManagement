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
            label7 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            productNameLabel = new Label();
            label8 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            label9 = new Label();
            textBox6 = new TextBox();
            label10 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            label13 = new Label();
            textBox7 = new TextBox();
            label14 = new Label();
            textBox8 = new TextBox();
            label15 = new Label();
            textBox9 = new TextBox();
            label16 = new Label();
            textBox10 = new TextBox();
            label17 = new Label();
            textBox11 = new TextBox();
            label18 = new Label();
            addProductButton = new Button();
            dateTimePicker2 = new DateTimePicker();
            label19 = new Label();
            EditPrButton = new Button();
            textBox12 = new TextBox();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            DeletePrButton = new Button();
            button2 = new Button();
            textBox13 = new TextBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            button3 = new Button();
            button4 = new Button();
            textBox18 = new TextBox();
            label31 = new Label();
            textBox19 = new TextBox();
            label32 = new Label();
            label33 = new Label();
            label34 = new Label();
            label37 = new Label();
            textBox24 = new TextBox();
            label41 = new Label();
            label42 = new Label();
            button6 = new Button();
            label30 = new Label();
            textBox16 = new TextBox();
            label35 = new Label();
            label36 = new Label();
            label38 = new Label();
            textBox20 = new TextBox();
            label39 = new Label();
            textBox21 = new TextBox();
            dateTimePicker3 = new DateTimePicker();
            label40 = new Label();
            comboBox1 = new ComboBox();
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
            welcomeTxt.Size = new Size(102, 21);
            welcomeTxt.TabIndex = 0;
            welcomeTxt.Text = "welcomeTxt";
            // 
            // button1
            // 
            button1.Location = new Point(997, 609);
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
            summaryPanel.Controls.Add(textBox21);
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
            summaryPanel.Size = new Size(440, 615);
            summaryPanel.TabIndex = 2;
            // 
            // availabilityList
            // 
            availabilityList.AutoSize = true;
            availabilityList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            availabilityList.Location = new Point(13, 44);
            availabilityList.Margin = new Padding(5, 0, 5, 0);
            availabilityList.Name = "availabilityList";
            availabilityList.Size = new Size(177, 21);
            availabilityList.TabIndex = 9;
            availabilityList.Text = "Списък с наличности";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 211);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
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
            lowStockGrid.Location = new Point(5, 234);
            lowStockGrid.Name = "lowStockGrid";
            lowStockGrid.ReadOnly = true;
            lowStockGrid.Size = new Size(420, 134);
            lowStockGrid.TabIndex = 5;
            // 
            // productName
            // 
            productName.DataPropertyName = "Name";
            productName.HeaderText = "Продукт";
            productName.Name = "productName";
            productName.ReadOnly = true;
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
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(InventoryManagement.Models.Product);
            // 
            // lastTransactionsLabel
            // 
            lastTransactionsLabel.AutoSize = true;
            lastTransactionsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lastTransactionsLabel.Location = new Point(5, 384);
            lastTransactionsLabel.Margin = new Padding(5, 0, 5, 0);
            lastTransactionsLabel.Name = "lastTransactionsLabel";
            lastTransactionsLabel.Size = new Size(185, 21);
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
            transactionStats.Size = new Size(420, 136);
            transactionStats.TabIndex = 3;
            // 
            // Product
            // 
            Product.DataPropertyName = "Product";
            Product.HeaderText = "Продукт";
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
            capacityLevel.Location = new Point(18, 556);
            capacityLevel.Margin = new Padding(5, 0, 5, 0);
            capacityLevel.Name = "capacityLevel";
            capacityLevel.Size = new Size(233, 21);
            capacityLevel.TabIndex = 2;
            capacityLevel.Text = "Използвано място в склада:";
            // 
            // productsBar
            // 
            productsBar.Location = new Point(18, 580);
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
            label2.Location = new Point(5, 23);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(402, 21);
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
            label3.Size = new Size(402, 21);
            label3.TabIndex = 8;
            label3.Text = "________________________________________________________";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Location = new Point(1036, 12);
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
            tabPage1.Controls.Add(DeletePrButton);
            tabPage1.Controls.Add(textBox12);
            tabPage1.Controls.Add(label20);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(EditPrButton);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(addProductButton);
            tabPage1.Controls.Add(textBox10);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(textBox11);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(textBox5);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(textBox7);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(textBox8);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(textBox9);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(textBox6);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(textBox4);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(productNameLabel);
            tabPage1.Controls.Add(label8);
            tabPage1.Location = new Point(4, 26);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(630, 537);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Продукти";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 23);
            label7.Name = "label7";
            label7.Size = new Size(146, 17);
            label7.TabIndex = 8;
            label7.Text = "Добавяне на продукт";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 264);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(171, 25);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 244);
            label5.Name = "label5";
            label5.Size = new Size(83, 17);
            label5.TabIndex = 6;
            label5.Text = "Количество";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(21, 204);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 25);
            textBox4.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 184);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 4;
            label6.Text = "Доставчик";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 25);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 125);
            label4.Name = "label4";
            label4.Size = new Size(72, 17);
            label4.TabIndex = 2;
            label4.Text = "Категория";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 25);
            textBox1.TabIndex = 1;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(21, 65);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(110, 17);
            productNameLabel.TabIndex = 0;
            productNameLabel.Text = "Име на продукт";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 40);
            label8.Name = "label8";
            label8.Size = new Size(143, 17);
            label8.TabIndex = 9;
            label8.Text = "___________________________";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(textBox13);
            tabPage2.Controls.Add(label23);
            tabPage2.Controls.Add(label24);
            tabPage2.Controls.Add(label25);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox18);
            tabPage2.Controls.Add(label31);
            tabPage2.Controls.Add(textBox19);
            tabPage2.Controls.Add(label32);
            tabPage2.Controls.Add(label33);
            tabPage2.Controls.Add(label34);
            tabPage2.Controls.Add(label37);
            tabPage2.Controls.Add(textBox24);
            tabPage2.Controls.Add(label41);
            tabPage2.Controls.Add(label42);
            tabPage2.Location = new Point(4, 26);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(630, 537);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Категории";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboBox1);
            tabPage3.Controls.Add(label40);
            tabPage3.Controls.Add(dateTimePicker3);
            tabPage3.Controls.Add(textBox20);
            tabPage3.Controls.Add(label39);
            tabPage3.Controls.Add(label38);
            tabPage3.Controls.Add(button6);
            tabPage3.Controls.Add(label30);
            tabPage3.Controls.Add(textBox16);
            tabPage3.Controls.Add(label35);
            tabPage3.Controls.Add(label36);
            tabPage3.Location = new Point(4, 26);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(630, 537);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Транзакции";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(480, 539);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Филтриране";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(480, 539);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Доставчици";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(480, 539);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Отчети";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 362);
            label9.Name = "label9";
            label9.Size = new Size(160, 17);
            label9.TabIndex = 12;
            label9.Text = "Последна актуализация";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(21, 322);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(171, 25);
            textBox6.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 302);
            label10.Name = "label10";
            label10.Size = new Size(41, 17);
            label10.TabIndex = 10;
            label10.Text = "Цена";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(21, 382);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(171, 25);
            dateTimePicker1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(221, 40);
            label11.Name = "label11";
            label11.Size = new Size(143, 17);
            label11.TabIndex = 15;
            label11.Text = "___________________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(221, 23);
            label12.Name = "label12";
            label12.Size = new Size(164, 17);
            label12.TabIndex = 16;
            label12.Text = "Редактиране на продукт";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(221, 264);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 25);
            textBox5.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(221, 244);
            label13.Name = "label13";
            label13.Size = new Size(104, 17);
            label13.TabIndex = 23;
            label13.Text = "Нов доставчик";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(221, 204);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(171, 25);
            textBox7.TabIndex = 22;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(221, 184);
            label14.Name = "label14";
            label14.Size = new Size(108, 17);
            label14.TabIndex = 21;
            label14.Text = "Нова категория";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(221, 145);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(171, 25);
            textBox8.TabIndex = 20;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(221, 125);
            label15.Name = "label15";
            label15.Size = new Size(146, 17);
            label15.TabIndex = 19;
            label15.Text = "Ново име на продукт";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(221, 85);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(171, 25);
            textBox9.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(221, 65);
            label16.Name = "label16";
            label16.Size = new Size(97, 17);
            label16.TabIndex = 17;
            label16.Text = "ID на продукт";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(221, 385);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(171, 25);
            textBox10.TabIndex = 28;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(221, 365);
            label17.Name = "label17";
            label17.Size = new Size(75, 17);
            label17.TabIndex = 27;
            label17.Text = "Нова цена";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(221, 325);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(171, 25);
            textBox11.TabIndex = 26;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(221, 305);
            label18.Name = "label18";
            label18.Size = new Size(120, 17);
            label18.TabIndex = 25;
            label18.Text = "Ново количество";
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
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(221, 440);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(171, 25);
            dateTimePicker2.TabIndex = 30;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(221, 420);
            label19.Name = "label19";
            label19.Size = new Size(77, 17);
            label19.TabIndex = 29;
            label19.Text = "Нова дата ";
            // 
            // EditPrButton
            // 
            EditPrButton.Location = new Point(252, 472);
            EditPrButton.Margin = new Padding(5, 4, 5, 4);
            EditPrButton.Name = "EditPrButton";
            EditPrButton.Size = new Size(101, 30);
            EditPrButton.TabIndex = 31;
            EditPrButton.Text = "Редактиране";
            EditPrButton.UseVisualStyleBackColor = true;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(418, 85);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(171, 25);
            textBox12.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(418, 65);
            label20.Name = "label20";
            label20.Size = new Size(97, 17);
            label20.TabIndex = 34;
            label20.Text = "ID на продукт";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(418, 23);
            label21.Name = "label21";
            label21.Size = new Size(151, 17);
            label21.TabIndex = 33;
            label21.Text = "Изтриване на продукт";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(418, 40);
            label22.Name = "label22";
            label22.Size = new Size(143, 17);
            label22.TabIndex = 32;
            label22.Text = "___________________________";
            // 
            // DeletePrButton
            // 
            DeletePrButton.Location = new Point(449, 118);
            DeletePrButton.Margin = new Padding(5, 4, 5, 4);
            DeletePrButton.Name = "DeletePrButton";
            DeletePrButton.Size = new Size(101, 30);
            DeletePrButton.TabIndex = 36;
            DeletePrButton.Text = "Изтриване";
            DeletePrButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(459, 124);
            button2.Margin = new Padding(5, 4, 5, 4);
            button2.Name = "button2";
            button2.Size = new Size(101, 30);
            button2.TabIndex = 73;
            button2.Text = "Изтриване";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(428, 91);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(171, 25);
            textBox13.TabIndex = 72;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(428, 71);
            label23.Name = "label23";
            label23.Size = new Size(108, 17);
            label23.TabIndex = 71;
            label23.Text = "ID на категория";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(428, 29);
            label24.Name = "label24";
            label24.Size = new Size(162, 17);
            label24.TabIndex = 70;
            label24.Text = "Изтриване на категория";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(428, 46);
            label25.Name = "label25";
            label25.Size = new Size(143, 17);
            label25.TabIndex = 69;
            label25.Text = "___________________________";
            // 
            // button3
            // 
            button3.Location = new Point(273, 183);
            button3.Margin = new Padding(5, 4, 5, 4);
            button3.Name = "button3";
            button3.Size = new Size(101, 30);
            button3.TabIndex = 68;
            button3.Text = "Редактиране";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(60, 123);
            button4.Margin = new Padding(5, 4, 5, 4);
            button4.Name = "button4";
            button4.Size = new Size(101, 30);
            button4.TabIndex = 43;
            button4.Text = "Добавяне";
            button4.UseVisualStyleBackColor = true;
            // 
            // textBox18
            // 
            textBox18.Location = new Point(231, 151);
            textBox18.Name = "textBox18";
            textBox18.Size = new Size(171, 25);
            textBox18.TabIndex = 57;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(231, 131);
            label31.Name = "label31";
            label31.Size = new Size(157, 17);
            label31.TabIndex = 56;
            label31.Text = "Ново име на категория";
            // 
            // textBox19
            // 
            textBox19.Location = new Point(231, 91);
            textBox19.Name = "textBox19";
            textBox19.Size = new Size(171, 25);
            textBox19.TabIndex = 55;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(231, 71);
            label32.Name = "label32";
            label32.Size = new Size(108, 17);
            label32.TabIndex = 54;
            label32.Text = "ID на категория";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(231, 29);
            label33.Name = "label33";
            label33.Size = new Size(175, 17);
            label33.TabIndex = 53;
            label33.Text = "Редактиране на категория";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(231, 46);
            label34.Name = "label34";
            label34.Size = new Size(143, 17);
            label34.TabIndex = 52;
            label34.Text = "___________________________";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(31, 29);
            label37.Name = "label37";
            label37.Size = new Size(157, 17);
            label37.TabIndex = 46;
            label37.Text = "Добавяне на категория";
            // 
            // textBox24
            // 
            textBox24.Location = new Point(31, 91);
            textBox24.Name = "textBox24";
            textBox24.Size = new Size(171, 25);
            textBox24.TabIndex = 38;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Location = new Point(31, 71);
            label41.Name = "label41";
            label41.Size = new Size(121, 17);
            label41.TabIndex = 37;
            label41.Text = "Име на категория";
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Location = new Point(31, 46);
            label42.Name = "label42";
            label42.Size = new Size(143, 17);
            label42.TabIndex = 47;
            label42.Text = "___________________________";
            // 
            // button6
            // 
            button6.Location = new Point(45, 290);
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
            label30.Location = new Point(29, 22);
            label30.Name = "label30";
            label30.Size = new Size(166, 17);
            label30.TabIndex = 72;
            label30.Text = "Добавяне на транзакция";
            // 
            // textBox16
            // 
            textBox16.Location = new Point(29, 84);
            textBox16.Name = "textBox16";
            textBox16.Size = new Size(171, 25);
            textBox16.TabIndex = 70;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(29, 64);
            label35.Name = "label35";
            label35.Size = new Size(97, 17);
            label35.TabIndex = 69;
            label35.Text = "ID на продукт";
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(29, 39);
            label36.Name = "label36";
            label36.Size = new Size(143, 17);
            label36.TabIndex = 73;
            label36.Text = "___________________________";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(29, 124);
            label38.Name = "label38";
            label38.Size = new Size(139, 17);
            label38.TabIndex = 81;
            label38.Text = "Тип на транзакцията";
            // 
            // textBox20
            // 
            textBox20.Location = new Point(29, 199);
            textBox20.Name = "textBox20";
            textBox20.Size = new Size(171, 25);
            textBox20.TabIndex = 84;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new Point(29, 179);
            label39.Name = "label39";
            label39.Size = new Size(83, 17);
            label39.TabIndex = 83;
            label39.Text = "Количество";
            // 
            // textBox21
            // 
            textBox21.BackColor = Color.WhiteSmoke;
            textBox21.Location = new Point(13, 75);
            textBox21.Multiline = true;
            textBox21.Name = "textBox21";
            textBox21.ReadOnly = true;
            textBox21.ScrollBars = ScrollBars.Vertical;
            textBox21.Size = new Size(412, 133);
            textBox21.TabIndex = 1;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(29, 258);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(171, 25);
            dateTimePicker3.TabIndex = 85;
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new Point(29, 238);
            label40.Name = "label40";
            label40.Size = new Size(38, 17);
            label40.TabIndex = 86;
            label40.Text = "Дата";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Входяща", "Изходяща" });
            comboBox1.Location = new Point(29, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 25);
            comboBox1.TabIndex = 87;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1110, 639);
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
        private TextBox textBox1;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox2;
        private Label label4;
        private Label label7;
        private Label label8;
        private Label availabilityList;
        private Label label12;
        private Label label11;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox textBox6;
        private Label label10;
        private TextBox textBox5;
        private Label label13;
        private TextBox textBox7;
        private Label label14;
        private TextBox textBox8;
        private Label label15;
        private TextBox textBox9;
        private Label label16;
        private Button EditPrButton;
        private DateTimePicker dateTimePicker2;
        private Label label19;
        private Button addProductButton;
        private TextBox textBox10;
        private Label label17;
        private TextBox textBox11;
        private Label label18;
        private TextBox textBox12;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button DeletePrButton;
        private Button button2;
        private TextBox textBox13;
        private Label label23;
        private Label label24;
        private Label label25;
        private Button button3;
        private Button button4;
        private TextBox textBox18;
        private Label label31;
        private TextBox textBox19;
        private Label label32;
        private Label label33;
        private Label label34;
        private Label label37;
        private TextBox textBox24;
        private Label label41;
        private Label label42;
        private Button button6;
        private Label label30;
        private TextBox textBox16;
        private Label label35;
        private Label label36;
        private TextBox textBox20;
        private Label label39;
        private Label label38;
        private TextBox textBox21;
        private Label label40;
        private DateTimePicker dateTimePicker3;
        private ComboBox comboBox1;
    }
}