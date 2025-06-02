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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }
        SupplierService supplierService;

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            supplierService = new SupplierService();
            PrintAllSuppliers();
        }
        private void PrintAllSuppliers()
        {
            var suppliers = supplierService.GetAllSuppliers();
            var sb = new StringBuilder();
            foreach (var s in suppliers)
            {
                sb.AppendLine($"• {s.SupplierId} - {s.Name} - {s.ContactName} - {s.Phone} - {s.Email}");
            }
            supplierListTxtBox.Clear();
            supplierListTxtBox.Text += sb.ToString();
        }
    }
}
