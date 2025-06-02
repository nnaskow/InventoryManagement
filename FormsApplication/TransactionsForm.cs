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
    public partial class TransactionsForm : Form
    {
        public TransactionsForm()
        {
            InitializeComponent();
        }
        TransactionService transactionService;
        private void TransactionsForm_Load(object sender, EventArgs e)
        {
            transactionService = new TransactionService();
            PrintAllTranscations();
        }
        private void PrintAllTranscations()
        {
            var transactions = transactionService.GetAllTransactions();
            var sb = new StringBuilder();
            foreach (var t in transactions)
            {
                sb.AppendLine($"• {t.TransactionId} - {t.Product.Name} - {t.TransactionType} - {t.TransactionDate}");
            }
            transactionListTxtBox.Clear();
            transactionListTxtBox.Text += sb.ToString();
        }
    }
}
