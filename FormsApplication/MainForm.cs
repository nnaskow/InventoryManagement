using InventoryManagement.Models;
using InventoryManagement.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Globalization;

namespace FormsApplication
{
    public partial class MainForm : Form
    {
        private string _username;
        DateTime baseTime;
        int secondsToAdd = 0;

        TransactionService transactionService = new TransactionService();
        ProductService productService = new ProductService();
        CategoryService categoryService = new CategoryService();
        SupplierService supplierService = new SupplierService();
        public MainForm(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            summaryPanel.BackColor = Color.FromArgb(180, 0, 0, 0);
            ApplyWarehouseBlueTheme();
            var lowStockProducts = productService.GetLowStockProducts(5);
            var recentTransactions = transactionService.GetLastTransactions(5);
            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();
            var suppliers = supplierService.GetAllSuppliers();
            var sb = new StringBuilder();
            foreach (var p in products)
            {
                sb.AppendLine($"• {p.Name} - {p.Quantity} бр.");
            }

            txtBoxShowList.Text = sb.ToString();
            productsBar.Value = productService.GetTotalProductCount();
            welcomeTxt.Text = $"Добре дошли, {_username}!";
            timeLabel.Visible = false;
            baseTime = DateTime.Now;
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            UpdateWarehouseCapacity();
            UpdateDashboardData();
            UpdateComboBoxes();
        }
        //Updates
        private void UpdateDashboardData()
        {
            int used = productService.GetTotalProductCount();
            capacityLevel.Text = $"Използвано място в склада: {used}/{productsBar.Maximum}";
            productsBar.Value = Math.Min(used, productsBar.Maximum);


            var recentTransactions = transactionService.GetAllTransactions();
            transactionStats.DataSource = null;
            transactionStats.DataSource = recentTransactions
                .Select(t => new
                {
                    Product = t.Product?.Name ?? "(няма име)",
                    TransactionType = t.TransactionType,
                    Quantity = t.Quantity,
                    TransactionDate = t.TransactionDate.HasValue
                        ? t.TransactionDate.Value.ToDateTime(TimeOnly.MinValue).ToString("yyyy-MM-dd")
                        : "(няма дата)"
                })
                .ToList();
            var lowStockProducts = productService.GetLowStockProducts(5);
            lowStockGrid.AutoGenerateColumns = true;
            lowStockGrid.DataSource = null;
            lowStockGrid.DataSource = lowStockProducts
                .Select(p => new
                {
                    ProductName = string.IsNullOrWhiteSpace(p.Name) ? "(няма име)" : p.Name,
                    Category = p.Category?.Name ?? "(няма категория)",
                    Quantity = p.Quantity,
                    Supplier = p.Supplier?.Name ?? "(няма доставчик)"
                })
                .ToList();
        }

        private void UpdateWarehouseCapacity()
        {
            int used = productService.GetTotalProductCount();
            capacityLevel.Text = $"Използвано място в склада: {used}/{productsBar.Maximum}";
            productsBar.Value = Math.Min(used, productsBar.Maximum);
        }
        private void UpdateComboBoxes()
        {
            var products = productService.GetAllProducts();
            var categories = categoryService.GetAllCategories();
            var suppliers = supplierService.GetAllSuppliers();

            FillComboBoxes(products, categories, suppliers);
        }

        //Top Right Timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsToAdd++;
            timeLabel.Text = baseTime.AddSeconds(secondsToAdd).ToString("HH:mm:ss");
            timeLabel.Visible = true;
        }

        //Exit Button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //tabs
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) //products
            {
                PrintAllProducts();
            }
            else if (tabControl1.SelectedTab == tabPage2) //categories
            {
                PrintAllCategories();
            }
            else if (tabControl1.SelectedTab == tabPage4) //transactions
            {
                PrintAllProducts();
            }
            else if (tabControl1.SelectedTab == tabPage5) //suppliers
            {
                PrintAllSuppliers();
            }
            else if (tabControl1.SelectedTab == tabPage6) //reports
            {
                PrintAllProducts();
            }

        }

        //Prints
        private void PrintAllProducts()
        {
            var products = productService.GetAllProducts();
            var sb = new StringBuilder();
            foreach (var p in products)
            {
                sb.AppendLine($"•  {p.ProductId} - {p.Name}");
            }
            availabilityList.Text = "Списък с продукти";
            txtBoxShowList.Clear();
            txtBoxShowList.Text += sb.ToString();
        }
        private void PrintAllSuppliers()
        {
            var suppliers = supplierService.GetAllSuppliers();
            var sb = new StringBuilder();
            foreach (var s in suppliers)
            {
                sb.AppendLine($"• {s.SupplierId} - {s.Name}");
            }
            availabilityList.Text = "Списък с доставчици";
            txtBoxShowList.Clear();
            txtBoxShowList.Text += sb.ToString();
        }
        private void PrintAllCategories()
        {
            var categories = categoryService.GetAllCategories();
            var sb = new StringBuilder();
            foreach (var category in categories)
            {
                sb.AppendLine($"• {category.CategoryId} - {category.Name}");
            }
            availabilityList.Text = "Списък с категории";
            txtBoxShowList.Clear();
            txtBoxShowList.Text += sb.ToString();
        }

        //Combobox OnClick Events for txtBoxShowList
        private void SupplierComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllSuppliers();
        }
        private void categoryComboBox_Click(object sender, EventArgs e)
        {
            PrintAllCategories();
        }
        private void CatIDEditCat_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllCategories();
        }
        private void catIDDelCat_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllCategories();
        }
        private void prodIDAddTr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllProducts();
        }
        private void newProductIDDelPr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllProducts();
        }
        private void newCatEditPr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllCategories();
        }
        private void newSupplierEditPr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllSuppliers();
        }
        private void newProductIDEdit_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllProducts();
        }
        private void newProductIDEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(newProductIDEdit.Text);
            var products = productService.GetProductById(num);
            newNameEditPr.Text = products.Name;
            newCatEditPr.Text = products.CategoryId.ToString();
            newSupplierEditPr.Text = products.SupplierId.ToString();
            newPriceEditPr.Text = products.Price.ToString();
            newQuantityEditPr.Text = products.Quantity.ToString();
        }

        //Button events for opening forms for each list ( Products, Category, Transactions, Suppliers )
        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm pr = new ProductsForm();
            pr.Show();
        } // productsForm
        private void button8_Click(object sender, EventArgs e)
        {
            CategoriesForm c = new CategoriesForm();
            c.Show();
        } // categoriesForm
        private void button7_Click(object sender, EventArgs e)
        {
            TransactionsForm t = new TransactionsForm();
            t.Show();
        } // transactionsForm
        private void button5_Click(object sender, EventArgs e)
        {
            SupplierForm s = new SupplierForm();
            s.Show();
        } // suppliersForm

        //Filter tab functionalities
        private void filterByCatButton_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategories();
            var products = productService.GetAllProducts();

            var groupedProducts = categories.Select(cat => new
            {
                CategoryName = cat.Name,
                Products = products.Where(p => p.CategoryId == cat.CategoryId).ToList()
            });

            var output = new StringBuilder();

            foreach (var group in groupedProducts)
            {
                output.AppendLine($"Категория: {group.CategoryName}");
                foreach (var product in group.Products)
                {
                    output.AppendLine($"  - {product.Name}");
                }
                output.AppendLine();
            }
            filterByCatTxtBox.Text = output.ToString();
        }
        private void filterBySupplierButton_Click(object sender, EventArgs e)
        {
            var suppliers = supplierService.GetAllSuppliers();
            var products = productService.GetAllProducts();

            var groupedProducts = suppliers.Select(s => new
            {
                SupplierName = s.Name,
                Products = products.Where(p => p.SupplierId == s.SupplierId).ToList()
            });

            var output = new StringBuilder();

            foreach (var group in groupedProducts)
            {
                output.AppendLine($"Доставчик: {group.SupplierName}");
                foreach (var product in group.Products)
                {
                    output.AppendLine($"  - {product.Name}");
                }
                output.AppendLine();
            }

            filterBySupTxtBox.Text = output.ToString();
        }

        //Report tab functionalities
        private void CatReportButton_Click(object sender, EventArgs e)
        {
            var categories = categoryService.GetAllCategories();
            var products = productService.GetAllProducts();
            var suppliers = supplierService.GetAllSuppliers();

            var output = new StringBuilder();

            foreach (var category in categories)
            {
                var catProducts = products.Where(p => p.CategoryId == category.CategoryId).ToList();
                var productCount = catProducts.Count;
                var totalValue = catProducts.Sum(p => p.Price);

                output.AppendLine($"Категория: {category.Name}");

                foreach (var product in catProducts)
                {
                    var supplier = suppliers.FirstOrDefault(s => s.SupplierId == product.SupplierId);
                    var supplierName = supplier != null ? supplier.Name : "Неизвестен доставчик";
                    output.AppendLine($"  - {product.Name} (Доставчик: {supplierName})");
                }

                output.AppendLine($"  Брой продукти: {productCount}");
                output.AppendLine($"  Обща стойност: {totalValue:C}");
                output.AppendLine();
            }

            catReportTxtBox.Text = output.ToString();
        }
        private void lowStockButton_Click(object sender, EventArgs e)
        {
            int threshold = 5;

            var lowStockProducts = productService.GetLowStockProducts(threshold);
            var groupedByCategory = lowStockProducts.GroupBy(p => p.Category);

            var output = new StringBuilder();

            foreach (var group in groupedByCategory)
            {
                var categoryName = group.Key != null ? group.Key.Name : "Неизвестна категория";
                var productCount = group.Count();
                var totalValue = group.Sum(p => p.Price * p.Quantity);

                output.AppendLine($"Категория: {categoryName}");

                foreach (var product in group)
                {
                    var supplierName = product.Supplier != null ? product.Supplier.Name : "Неизвестен доставчик";
                    output.AppendLine($"  - {product.Name} (Доставчик: {supplierName}, Наличност: {product.Quantity})");
                }

                output.AppendLine($"  Брой продукти с ниска наличност: {productCount}");
                output.AppendLine($"  Обща стойност (налично): {totalValue:C}");
                output.AppendLine();
            }

            lowStockReportTxtBox.Text = output.ToString();
        }

        //PopulateComboboxes
        private void PopulateComboBoxWithIds<T>(ComboBox comboBox, List<T> items, Func<T, object> idSelector)
        {
            comboBox.Items.Clear();

            foreach (var item in items)
            {
                comboBox.Items.Add(idSelector(item));
            }
        }
        private void FillComboBoxes(List<Product> products, List<Category> categories, List<Supplier> suppliers)
        {
            PopulateComboBoxWithIds(categoryComboBox, categories, c => c.CategoryId);
            PopulateComboBoxWithIds(SupplierComboBox, suppliers, s => s.SupplierId);
            PopulateComboBoxWithIds(newCatEditPr, categories, c => c.CategoryId);
            PopulateComboBoxWithIds(newSupplierEditPr, suppliers, s => s.SupplierId);
            PopulateComboBoxWithIds(supIDEditSup, suppliers, s => s.SupplierId);
            PopulateComboBoxWithIds(SupIDDelSup, suppliers, s => s.SupplierId);
            PopulateComboBoxWithIds(newProductIDDelPr, products, p => p.ProductId);
            PopulateComboBoxWithIds(newProductIDEdit, products, p => p.ProductId);
            PopulateComboBoxWithIds(prodIDAddTr, products, p => p.ProductId);
            PopulateComboBoxWithIds(catIDDelCat, categories, p => p.CategoryId);
            PopulateComboBoxWithIds(CatIDEditCat, categories, p => p.CategoryId);
        }

        //Design
        private void ApplyWarehouseBlueTheme()
        {
            this.BackColor = ColorTranslator.FromHtml("#0D1B2A");

            summaryPanel.BackColor = Color.FromArgb(180, 13, 27, 42);

            tabControl1.BackColor = ColorTranslator.FromHtml("#1B263B");
            tabControl1.ForeColor = ColorTranslator.FromHtml("#E0E1DD");

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.BackColor = ColorTranslator.FromHtml("#1B263B");
                tab.ForeColor = ColorTranslator.FromHtml("#E0E1DD");
            }

            StyleButton(button1);
            StyleButton(ProductsButton);
            StyleButton(transcationButton);
            StyleButton(addProductButton);
            StyleButton(DeletePrButton);
            StyleButton(addCatButton);
            StyleButton(editCatButton);
            StyleButton(delCatButton);
            StyleButton(addSupplierButton);
            StyleButton(editSupplierButton);
            StyleButton(delSuplierButton);
            StyleButton(addTransButton);
            StyleButton(lowStockButton);
            StyleButton(CatReportButton);
            StyleButton(filterBySupplierButton);
            StyleButton(filterByCatButton);
            StyleButton(button8);
            StyleButton(button5);
            StyleButton(EditPrButton);
        }
        private void StyleButton(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#415A77");
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }
        //ProductButtons
        private void addProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = productNameTxtBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Моля, въведи име на продукта.");
                    return;
                }

                if (!int.TryParse(categoryComboBox.Text, out int categoryId))
                {
                    MessageBox.Show("Моля избери валидна категория.");
                    return;
                }

                if (!int.TryParse(SupplierComboBox.Text, out int supplierId))
                {
                    MessageBox.Show("Моля, избери доставчик.");
                    return;
                }
                int quantity = int.Parse(QuantityTextBox.Text);
                decimal price = decimal.Parse(priceTextBox.Text);

                DateOnly lastUpdate = DateOnly.FromDateTime(lastUpdateDTPicker.Value);

                productService.AddProduct(name, categoryId, supplierId, quantity, price, lastUpdate);
                MessageBox.Show("Продуктът беше добавен успешно!");
                UpdateWarehouseCapacity();
                UpdateComboBoxes();
                UpdateDashboardData();
                transactionService.AddTransactionForINEntriesOnly(productService.GetLastInsertedProductId(), "IN", quantity, DateOnly.FromDateTime(DateTime.Now));
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля въведи валидни стойности във всички полета.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }

        }
        private void DeletePrButton_Click(object sender, EventArgs e)
        {
            int productId = int.Parse(newProductIDDelPr.Text);
            if (newProductIDDelPr.SelectedItem == null) { MessageBox.Show("Моля избери валиден идентификационен номер."); return; }
            productService.DeleteProduct(productId);
            MessageBox.Show("Продуктът е изтрит успешно!");
            UpdateWarehouseCapacity();
            UpdateComboBoxes();
            UpdateDashboardData();
        }

        private void EditPrButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(newProductIDEdit.Text, out int productId))
                {
                    MessageBox.Show("Моля въведи валиден идентификационен номер на продукта.");
                    return;
                }

                string newName = newNameEditPr.Text.Trim();
                if (string.IsNullOrEmpty(newName))
                {
                    MessageBox.Show("Моля въведи име на продукта.");
                    return;
                }

                if (!int.TryParse(newCatEditPr.Text, out int newCategory))
                {
                    MessageBox.Show("Моля избери валидна категория.");
                    return;
                }

                if (!int.TryParse(newSupplierEditPr.Text, out int newSupplier))
                {
                    MessageBox.Show("Моля избери валиден доставчик.");
                    return;
                }

                if (!int.TryParse(newQuantityEditPr.Text, out int newQuantity))
                {
                    MessageBox.Show("Въведи валидно количество.");
                    return;
                }

                if (!decimal.TryParse(newPriceEditPr.Text, out decimal newPrice))
                {
                    MessageBox.Show("Въведи валидна цена.");
                    return;
                }

                DateOnly newDateEditPr = DateOnly.FromDateTime(lastUpdateDTPicker.Value);

                productService.EditProduct(productId, newName, newCategory, newSupplier, newQuantity, newPrice, newDateEditPr);
                MessageBox.Show("Продуктът е редактиран успешно.");
                UpdateWarehouseCapacity();
                UpdateDashboardData();
                UpdateComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        //CategoryButtons
        private void addCatButton_Click(object sender, EventArgs e)
        {
            try
            {
                string categoryName = CatNameAddCat.Text;
                if (CatNameAddCat.Text == null) { MessageBox.Show("Моля напишете име на категория."); return; }
                categoryService.AddCategory(categoryName);
                MessageBox.Show("Категорията бе добавена успешно!");
                UpdateComboBoxes();
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля въведи валидни стойности във всички полета.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        private void editCatButton_Click(object sender, EventArgs e)
        {
            try
            {
                int maxCategoryId = categoryService.GetAllCategories()
                                       .OrderByDescending(c => c.CategoryId).FirstOrDefault()?.CategoryId ?? 0;
                int newCatId = int.Parse(CatIDEditCat.Text);
                if (newCatId >= maxCategoryId || newCatId == 0) { MessageBox.Show("Моля напишете валиден идентификационен номер на категория."); return; }
                string newCatName = newNameEditCat.Text;
                if (newNameEditCat.Text == null) { MessageBox.Show("Моля напишете име на категория."); return; }
                categoryService.EditCategory(newCatId, newCatName);
                UpdateComboBoxes();
                UpdateDashboardData();
                MessageBox.Show("Категорията бе редактирана успешно.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля въведи валидни стойности във всички полета.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        private void delCatButton_Click(object sender, EventArgs e)
        {
            try
            {

                int maxCategoryId = categoryService.GetAllCategories()
                                       .OrderByDescending(c => c.CategoryId).FirstOrDefault()?.CategoryId ?? 0;
                int catId = int.Parse(catIDDelCat.Text);
                if (catId >= maxCategoryId || catId == 0) { MessageBox.Show("Моля избери валиден идентификационен номер."); return; }
                categoryService.DeleteCategory(catId);
                MessageBox.Show("Категорията е изтрита успешно!");
                UpdateComboBoxes();
                UpdateDashboardData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Моля въведи валидни стойности във всички полета.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }
        }

        //Transactionbutton
        private void addTransButton_Click(object sender, EventArgs e)
        {
            int maxProductId = productService.GetAllProducts()
                                  .OrderByDescending(c => c.ProductId).FirstOrDefault()?.ProductId ?? 0;
            int productId = int.Parse(prodIDAddTr.Text);
            string transType = "";
            if (productId > maxProductId || productId == 0)
            {
                MessageBox.Show("Моля избери валиден идентификационен номер."); return;
            }
            if (transTypeAddTr.Text == "Входяща")
            {
                transType = "IN";
            }
            else if (transTypeAddTr.Text == "Изходяща")
            {
                transType = "OUT";

            }
            else
            {
                MessageBox.Show("Моля въведете правилни данни."); return;
            }
            int quantity = int.Parse(quantityAddTr.Text);
            if (quantity == 0) { MessageBox.Show("Въведете правилно количество."); return; }
            DateOnly date = DateOnly.FromDateTime(lastUpdateDTPicker.Value);
            transactionService.AddTransaction(productId, transType, quantity, date);
            MessageBox.Show("Транзакцията бе добавена.");
            UpdateDashboardData();
            UpdateWarehouseCapacity();
        }

        //Supplierbuttons
        private void delSuplierButton_Click(object sender, EventArgs e)
        {
            int maxSupplierId = supplierService.GetAllSuppliers()
                                       .OrderByDescending(c => c.SupplierId).FirstOrDefault()?.SupplierId ?? 0;
            int supplierId = int.Parse(SupIDDelSup.Text);
            if (supplierId > maxSupplierId || supplierId == 0) { MessageBox.Show("Моля напишете валиден идентификационен номер на доставчик."); return; }
            supplierService.DeleteSupplier(supplierId);
            MessageBox.Show("Успешно изтрихте доставчика.");
            UpdateComboBoxes();
            UpdateDashboardData();
        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            string supplierName = supplierNameAddSup.Text;
            if (supplierName == "")
            {
                MessageBox.Show("Моля напишете име на доставчик."); return;
            }
            string contactName = ContactNameAddSup.Text;
            if (contactName == "")
            {
                MessageBox.Show("Моля напишете име на контакт."); return;
            }
            string phoneNumber = PhoneAddSup.Text;
            if (phoneNumber == "")
            {
                MessageBox.Show("Моля напишете телефон на контакт."); return;
            }
            string email = EmailAddSup.Text;
            if (email == "")
            {
                MessageBox.Show("Моля напишете имайл на контакт."); return;
            }
            supplierService.AddSupplier(supplierName, contactName, phoneNumber, email);
            MessageBox.Show("Доставчикът беше добавен.");
            UpdateComboBoxes();
            UpdateDashboardData();
        }

        private void editSupplierButton_Click(object sender, EventArgs e)
        {
            int maxSupplierId = supplierService.GetAllSuppliers()
                                  .OrderByDescending(c => c.SupplierId).FirstOrDefault()?.SupplierId ?? 0;
            int supplierId = int.Parse(supIDEditSup.Text);
            if (supplierId > maxSupplierId || supplierId == 0)
            {
                MessageBox.Show("Моля избери валиден идентификационен номер."); return;
            }
            string newSupplierName = newNameEdSup.Text;
            if (newSupplierName == "")
            {
                MessageBox.Show("Моля напишете име на доставчик."); return;
            }
            string newContactName = newContactEdSup.Text;
            if (newContactName == "")
            {
                MessageBox.Show("Моля напишете име на контакт."); return;
            }
            string newPhoneNumber = newPhoneEdSup.Text;
            if (newPhoneNumber == "")
            {
                MessageBox.Show("Моля напишете телефон на контакт."); return;
            }
            string newEmail = newEmailEdSup.Text;
            if (newEmail == "")
            {
                MessageBox.Show("Моля напишете имайл на контакт."); return;
            }
            supplierService.EditSupplier(supplierId, newSupplierName, newContactName, newPhoneNumber, newEmail);
            MessageBox.Show("Доставчикът бе редактиран успешно.");
            UpdateComboBoxes();
            UpdateDashboardData();

        }

        private void CatIDEditCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(CatIDEditCat.Text);
            var categories = categoryService.GetCategoryById(num);
            newNameEditCat.Text = categories.Name;
        }

        private void supIDEditSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            int num = int.Parse(supIDEditSup.Text);
            var suppliers = supplierService.GetSupplierById(num);
            newNameEdSup.Text = suppliers.Name;
            newContactEdSup.Text = suppliers.ContactName;
            newEmailEdSup.Text = suppliers.Email;
            newPhoneEdSup.Text = suppliers.Phone;
            newContactEdSup.Text = suppliers.ContactName;
        }
    }
}
