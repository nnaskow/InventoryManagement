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
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }
        CategoryService categoryService;

        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            categoryService = new CategoryService();
            PrintAllCategories();
        }
        private void PrintAllCategories()
        {
            var categories = categoryService.GetAllCategories();
            var sb = new StringBuilder();
            foreach (var p in categories)
            {
                sb.AppendLine($"• {p.CategoryId} - {p.Name}");
            }
            categoriesListTxtBox.Clear();
            categoriesListTxtBox.Text += sb.ToString();
        }
    }
}
