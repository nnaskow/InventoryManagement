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

          //  txtlistLabel.Text = sb.ToString();
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
                //txtlistLabel.Text = "Products selected";

            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
           // txtlistLabel.Text = "Categories selected";

            }
        }
    }
}
