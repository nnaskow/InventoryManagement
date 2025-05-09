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
        public void AddProduct(string name, int categoryId, int supplierId, int quantity, decimal price )
        {
            var product = new Product
            {
                Name = name,
                CategoryId = categoryId,
                SupplierId = supplierId,
                Quantity = quantity,
                Price = price,
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
                _context.Products.Remove(product);
                _context.SaveChanges();
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
    }

}
