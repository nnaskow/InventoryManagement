using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    /// <summary>
    /// Услуга за управление на продукти в системата за инвентаризация.
    /// </summary>
    public class ProductService
    {
        /// <summary>
        /// Добавя нов продукт към базата данни.
        /// </summary>
        /// <param name="name">Име на продукта.</param>
        /// <param name="categoryId">ID на категорията.</param>
        /// <param name="supplierId">ID на доставчика.</param>
        /// <param name="quantity">Количество в наличност.</param>
        /// <param name="price">Цена на продукта.</param>
        /// <param name="LastUpdated">Дата на последна актуализация (подава се, но се презаписва с текущата).</param>
        public void AddProduct(string name, int categoryId, int supplierId, int quantity, decimal price, DateOnly LastUpdated)
        {
            var product = new Product
            {
                Name = name,
                CategoryId = categoryId,
                SupplierId = supplierId,
                Quantity = quantity,
                Price = price,
                LastUpdated = DateOnly.FromDateTime(DateTime.Now)
            };
            using (var context = new InventoryManagementContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Връща списък с всички продукти, включително техните категории и доставчици.
        /// </summary>
        public List<Product> GetAllProducts()
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.Include(p => p.Category).Include(p => p.Supplier).ToList();
            }
        }

        /// <summary>
        /// Връща продукт по зададен идентификатор, включително категория и доставчик.
        /// </summary>
        /// <param name="productId">ID на продукта.</param>
        /// <returns>Продуктът или null, ако не съществува.</returns>
        public Product GetProductById(int productId)
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.Include(p => p.Category).Include(p => p.Supplier)
                    .FirstOrDefault(p => p.ProductId == productId);
            }
        }

        /// <summary>
        /// Редактира съществуващ продукт с нови стойности.
        /// </summary>
        /// <param name="productId">ID на продукта за редакция.</param>
        /// <param name="newName">Ново име.</param>
        /// <param name="newCategoryId">Нова категория.</param>
        /// <param name="newSupplierId">Нов доставчик.</param>
        /// <param name="newQuantity">Ново количество.</param>
        /// <param name="newPrice">Нова цена.</param>
        /// <param name="newLastUpdated">Нова дата на актуализация.</param>
        public void EditProduct(int productId, string newName, int newCategoryId, int newSupplierId, int newQuantity, decimal newPrice, DateOnly newLastUpdated)
        {
            using (var context = new InventoryManagementContext())
            {
                var product = context.Products.FirstOrDefault(p => p.ProductId == productId);

                if (product != null)
                {
                    product.Name = newName;
                    product.CategoryId = newCategoryId;
                    product.SupplierId = newSupplierId;
                    product.Quantity = newQuantity;
                    product.Price = newPrice;
                    product.LastUpdated = newLastUpdated;

                    context.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Изтрива продукт по зададено ID, включително свързаните с него транзакции.
        /// Нулира ID стойността на таблицата след изтриване.
        /// </summary>
        /// <param name="productId">ID на продукта за изтриване.</param>
        public void DeleteProduct(int productId)
        {
            using (var context = new InventoryManagementContext())
            {
                var product = context.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product != null)
                {
                    var transactions = context.Transactions.Where(t => t.ProductId == productId).ToList();
                    foreach (var transaction in transactions)
                    {
                        context.Transactions.Remove(transaction);
                    }

                    context.Products.Remove(product);
                    context.SaveChanges();

                    var maxId = context.Products.Max(p => p.ProductId);
                    context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('products', RESEED, {maxId})");

                    Console.WriteLine("Продуктът беше изтрит и ID стойността беше актуализирана!");
                }
            }
        }

        /// <summary>
        /// Връща ID на последно добавения продукт.
        /// </summary>
        /// <returns>Цяло число – ID на последния продукт, или 0 ако няма такива.</returns>
        public int GetLastInsertedProductId()
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.OrderByDescending(p => p.ProductId).FirstOrDefault()?.ProductId ?? 0;
            }
        }

        /// <summary>
        /// Връща общия брой налични продукти (сумарно по количества).
        /// </summary>
        /// <returns>Цяло число – общо налично количество.</returns>
        public int GetTotalProductCount()
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.Sum(p => p.Quantity.GetValueOrDefault());
            }
        }

        /// <summary>
        /// Връща списък с продукти, чието количество е под дадена стойност.
        /// </summary>
        /// <param name="num">Праг за ниско количество.</param>
        /// <returns>Списък от продукти с нисък складов статус.</returns>
        public List<Product> GetLowStockProducts(int num)
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products
                    .Where(p => p.Quantity < num)
                    .Include(p => p.Category)
                    .Include(p => p.Supplier)
                    .ToList();
            }
        }
    }
}
