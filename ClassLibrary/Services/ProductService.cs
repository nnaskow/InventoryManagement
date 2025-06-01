using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace InventoryManagement.Services
{
    public class ProductService
    {

        public void AddProduct(string name, int categoryId, int supplierId, int quantity, decimal price,DateOnly LastUpdated)
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

        public List<Product> GetAllProducts()
        {
            using (var context = new InventoryManagementContext()) {
                return context.Products.Include(p => p.Category).Include(p => p.Supplier).ToList();
            }
        }

        public Product GetProductById(int productId)
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.Include(p => p.Category).Include(p => p.Supplier)
                .FirstOrDefault(p => p.ProductId == productId);
            }
        }

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

        public int GetLastInsertedProductId()
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.OrderByDescending(p => p.ProductId).FirstOrDefault()?.ProductId ?? 0;
            }
        }
        public int GetTotalProductCount()
        {
            using (var context = new InventoryManagementContext())
            {
                return context.Products.Count();
            }
        }
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
