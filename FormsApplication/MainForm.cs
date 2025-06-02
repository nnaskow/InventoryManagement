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
            var lowStockProducts = productService.GetLowStockProducts(5);
            var recentTransactions = transactionService.GetLastTransactions(5);
            var products = productService.GetAllProducts();
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
            capacityLevel.Text = $"Използвано място в склада: {productService.GetTotalProductCount()}/1000";
            transactionStats.DataSource = null;
            transactionStats.DataSource = recentTransactions
            .Select(t => new
            {
                Product = t.Product.Name,
                TransactionType = t.TransactionType,
                Quantity = t.Quantity,
                TranscationDate = t.TransactionDate
            }).ToList();
            lowStockGrid.DataSource = null;
            lowStockGrid.DataSource = lowStockProducts.Select(p => new
            {
                productName = p.Name ?? "(няма име)",
                Category = p.Category.Name,
                Quantity = p.Quantity,
                Supplier = p.Supplier.Name
            }).ToList();
            PopulateComboBoxWithIds(categoryComboBox, categories, p => p.CategoryId);
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsToAdd++;
            timeLabel.Text = baseTime.AddSeconds(secondsToAdd).ToString("HH:mm:ss");
            timeLabel.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                PrintAllProducts();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                PrintAllCategories();
            }
            else if (tabControl1.SelectedTab == tabPage4)
            {
                PrintAllProducts();
            }
            else if (tabControl1.SelectedTab == tabPage5)
            {
                PrintAllSuppliers();
            }
            else if (tabControl1.SelectedTab == tabPage6)
            {
                PrintAllProducts();
            }

        }

        private void SupplierComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllSuppliers();
        }
        private void categoryComboBox_Click(object sender, EventArgs e)
        {
            PrintAllCategories();
        }

        private void newCatEditPr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllCategories();
        }

        private void prIDEditProd_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllProducts();
        }

        private void PrintAllProducts()
        {
            var products = productService.GetAllProducts();
            var sb = new StringBuilder();
            foreach (var p in products)
            {
                sb.AppendLine($"•  {p.ProductId} - {p.Name}");
            }
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
            txtBoxShowList.Clear();
            txtBoxShowList.Text += sb.ToString();
        }

        private void newSupplierEditPr_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllSuppliers();
        }

        private void prodIDDelProd_MouseClick(object sender, MouseEventArgs e)
        {
            PrintAllProducts();
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

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            ProductsForm pr = new ProductsForm();
            pr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CategoriesForm c = new CategoriesForm();
            c.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TransactionsForm t = new TransactionsForm();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupplierForm s = new SupplierForm();
            s.Show();
        }

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

            filterByCatTxtBox.Text = output.ToString();
        }

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
        private void PopulateComboBoxWithIds<T>(ComboBox comboBox, List<T> items, Func<T, object> idSelector)
        {
            comboBox.Items.Clear();

            foreach (var item in items)
            {
                comboBox.Items.Add(idSelector(item));
            }
        }


    }
}
