using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    /// <summary>
    /// Услуга за управление на транзакции в инвентарната система.
    /// </summary>
    public class TransactionService
    {
        /// <summary>
        /// Добавя транзакция (входна или изходна) за даден продукт и актуализира наличността.
        /// </summary>
        /// <param name="productId">ID на продукта.</param>
        /// <param name="transactionType">Тип на транзакцията ("IN" или "OUT").</param>
        /// <param name="quantity">Количество.</param>
        /// <param name="transactionDate">Дата на транзакцията.</param>
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

        /// <summary>
        /// Добавя само входяща ("IN") транзакция без да актуализира количеството. (Полезно за начални данни.)
        /// </summary>
        /// <param name="productId">ID на продукта.</param>
        /// <param name="transactionType">Тип на транзакцията ("IN").</param>
        /// <param name="quantity">Количество.</param>
        /// <param name="transactionDate">Дата на транзакцията.</param>
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

        /// <summary>
        /// Връща списък с всички транзакции, включително данни за продукта.
        /// </summary>
        /// <returns>Списък от транзакции.</returns>
        public List<Transaction> GetAllTransactions()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Transactions
                    .Include(t => t.Product)
                    .ToList();
            }
        }

        /// <summary>
        /// Връща транзакция по зададено ID.
        /// </summary>
        /// <param name="transactionId">ID на транзакцията.</param>
        /// <returns>Обект Transaction или null, ако не е намерен.</returns>
        public Transaction GetTransactionById(int transactionId)
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Transactions.FirstOrDefault(t => t.TransactionId == transactionId);
            }
        }

        /// <summary>
        /// Връща последните N транзакции, подредени по дата.
        /// </summary>
        /// <param name="count">Брой транзакции за връщане.</param>
        /// <returns>Списък от последни транзакции.</returns>
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

        /// <summary>
        /// Изтрива транзакция и коригира количеството на продукта.
        /// </summary>
        /// <param name="transactionId">ID на транзакцията.</param>
        public void RemoveTransaction(int transactionId)
        {
            using (var _context = new InventoryManagementContext())
            {
                var transaction = _context.Transactions
                    .Include(t => t.Product)
                    .FirstOrDefault(t => t.TransactionId == transactionId);

                if (transaction == null)
                {
                    Console.WriteLine("Транзакцията не е намерена.");
                    return;
                }

                var product = transaction.Product;

                if (transaction.TransactionType == "IN")
                {
                    product.Quantity -= transaction.Quantity;
                }
                else if (transaction.TransactionType == "OUT")
                {
                    product.Quantity += transaction.Quantity;
                }

                _context.Transactions.Remove(transaction);
                _context.SaveChanges();
            }
        }
    }
}
