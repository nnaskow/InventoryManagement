using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class TransactionService
    {
        private readonly InventoryManagementContext _context;

        public TransactionService()
        {
            _context = new InventoryManagementContext();
        }

        public void AddTransaction(int productId, string transactionType, int quantity, DateOnly transactionDate)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product == null)
            {
                Console.WriteLine("Продуктът не съществува.");
                return;
            }

            if (transactionType == "OUT" && product.Quantity < quantity)
            {
                Console.WriteLine("Не е достатъчно количество за изтегляне.");
                return;
            }

            var transaction = new Transaction
            {
                ProductId = productId,
                TransactionType = transactionType,
                Quantity = quantity,
                TransactionDate = transactionDate
            };

            _context.Transactions.Add(transaction);

            if (transactionType == "IN")
            {
                product.Quantity += quantity; 
            }
            else if (transactionType == "OUT")
            {
                product.Quantity -= quantity;
            }

            _context.SaveChanges();
        }



        public List<Transaction> GetAllTransactions()
        {
            return _context.Transactions
                .Include(t => t.Product)
                .ToList();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _context.Transactions.FirstOrDefault(t => t.TransactionId == transactionId);
        }
    }
}
