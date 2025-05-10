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
        private readonly InventoryManagementContext _context;

        public ProductService()
        {
            _context = new InventoryManagementContext();
        }
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

            _context.Products.Add(product);

            _context.SaveChanges();
        }


        public List<Product> GetAllProducts()
        {
            return _context.Products.Include(p => p.Category).Include(p => p.Supplier).ToList();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products.Include(p => p.Category).Include(p => p.Supplier)
                .FirstOrDefault(p => p.ProductId == productId);
        }

        public void EditProduct(int productId, string newName, int newCategoryId, int newSupplierId, int newQuantity, decimal newPrice, DateOnly newLastUpdated)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);

            if (product != null)
            {
                product.Name = newName;
                product.CategoryId = newCategoryId;
                product.SupplierId = newSupplierId;
                product.Quantity = newQuantity;
                product.Price = newPrice;
                product.LastUpdated = newLastUpdated;

                _context.SaveChanges();
            }
        }

        public void DeleteProduct(int productId)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {             
                var transactions = _context.Transactions.Where(t => t.ProductId == productId).ToList();
                foreach (var transaction in transactions)
                {
                    _context.Transactions.Remove(transaction);
                }

                _context.Products.Remove(product);

                _context.SaveChanges();

                var maxId = _context.Products.Max(p => p.ProductId);
                _context.Database.ExecuteSqlRaw($"DBCC CHECKIDENT ('products', RESEED, {maxId})");

                Console.WriteLine("Продуктът беше изтрит и ID стойността беше актуализирана!");
            }
        }


        public List<Product> GetAllProduct()
        {
            return _context.Products.ToList();
        }
        public List<int> GetAllProductIds()
        {
            return _context.Products.Select(p => p.ProductId).ToList();
        }
        public int GetLastInsertedProductId()
        {
            return _context.Products.OrderByDescending(p => p.ProductId).FirstOrDefault()?.ProductId ?? 0;
        }
        public void UpdateProductQuantity(int productId, int quantityChange)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productId);
            if (product != null)
            {
                if (product.Quantity + quantityChange < 0)
                {
                    Console.WriteLine("Не е достатъчно количество на продукта.");
                    return;
                }

                product.Quantity += quantityChange;

                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Продуктът не съществува.");
            }
        }

    }

}
