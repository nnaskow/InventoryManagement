using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class TransactionService
    {

        public void AddTransaction(int productId, string transactionType, int quantity, DateOnly transactionDate)
        {
            using (var _context = new InventoryManagementContext())
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

                if (product == null)
                {
                    Console.WriteLine("Продуктът не съществува.");
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
        }
        public void AddTransactionForINEntriesOnly(int productId, string transactionType, int quantity, DateOnly transactionDate)
        {
            using (var _context = new InventoryManagementContext())
            {
                var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

                if (product == null)
                {
                    Console.WriteLine("Продуктът не съществува.");
                    return;
                }

                var transaction = new Transaction
                {
                    ProductId = productId,
                    TransactionType = transactionType,
                    Quantity = quantity,
                    TransactionDate = transactionDate
                };

                _context.SaveChanges();
            }
        }

        public List<Transaction> GetAllTransactions()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Transactions
                .Include(t => t.Product)
                .ToList();
            }
        }

        public Transaction GetTransactionById(int transactionId)
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Transactions.FirstOrDefault(t => t.TransactionId == transactionId);
            }
        }
        public List<Transaction> GetLastTransactions(int count)
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Transactions
                    .Include(t => t.Product)
                    .OrderByDescending(t => t.TransactionDate)
                    .Take(count)
                    .ToList();
            }
        }

    }
}
