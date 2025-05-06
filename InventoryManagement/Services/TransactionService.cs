using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var transaction = new Transaction
            {
                ProductId = productId,
                TransactionType = transactionType,
                Quantity = quantity,
                TransactionDate = transactionDate
            };

            _context.Transactions.Add(transaction);
            _context.SaveChanges();
        }

        public List<Transaction> GetAllTransactions()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _context.Transactions.FirstOrDefault(t => t.TransactionId == transactionId);
        }
    }
}
