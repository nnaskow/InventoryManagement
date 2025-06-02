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

namespace FormsApplication
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }
        ProductService productService;
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            productService = new ProductService();
            PrintAllProducts();
        }
        private void PrintAllProducts()
        {
            var products = productService.GetAllProducts();
            var sb = new StringBuilder();
            foreach (var p in products)
            {
                sb.AppendLine($"• {p.ProductId} - {p.Name} - {p.Quantity} - {p.Price} - {p.Supplier.Name}");
            }
            productsListTxtBox.Clear();
            productsListTxtBox.Text += sb.ToString();
        }
    }
}
