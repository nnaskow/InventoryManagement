using InventoryManagement.Models;
using InventoryManagement.Services;
using NUnit.Framework;
using System.Linq;

namespace ServicesTests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private ProductService service = new ProductService();

        [Test]
        public void AddProduct_ShouldAddProduct()
        {
            var categoryId = 1;
            var supplierId = 1;

            service.AddProduct("TestProduct", categoryId, supplierId, 10, 20.5m, DateOnly.FromDateTime(DateTime.Now));

            var products = service.GetAllProducts();
            var product = products[products.Count - 1];

            Assert.IsNotNull(product);
            Assert.AreEqual("TestProduct", product.Name);
            Assert.AreEqual(categoryId, product.CategoryId);
            Assert.AreEqual(supplierId, product.SupplierId);
            Assert.AreEqual(10, product.Quantity);
            Assert.AreEqual(20.5m, product.Price);

            service.DeleteProduct(product.ProductId);
        }

        [Test]
        public void EditProduct_ShouldUpdateProduct()
        {
            var categoryId = 1;
            var supplierId = 1;

            service.AddProduct("OldProduct", categoryId, supplierId, 5, 15m, DateOnly.FromDateTime(DateTime.Now));
            var products = service.GetAllProducts();
            var id = products[products.Count - 1].ProductId;

            service.EditProduct(id, "NewProduct", categoryId, supplierId, 20, 30m, DateOnly.FromDateTime(DateTime.Now));

            var edited = service.GetProductById(id);
            Assert.AreEqual("NewProduct", edited.Name);
            Assert.AreEqual(20, edited.Quantity);
            Assert.AreEqual(30m, edited.Price);

            service.DeleteProduct(id);
        }

        [Test]
        public void DeleteProduct_ShouldRemoveProduct()
        {
            var categoryId = 1;
            var supplierId = 1;

            service.AddProduct("ToDelete", categoryId, supplierId, 5, 15m, DateOnly.FromDateTime(DateTime.Now));
            var products = service.GetAllProducts();
            var id = products[products.Count - 1].ProductId;

            service.DeleteProduct(id);

            var deleted = service.GetProductById(id);
            Assert.IsNull(deleted);
        }

        [Test]
        public void GetAllProducts_ShouldReturnAllProducts()
        {
            var categoryId = 1;
            var supplierId = 1;

            service.AddProduct("Product1", categoryId, supplierId, 5, 15m, DateOnly.FromDateTime(DateTime.Now));
            service.AddProduct("Product2", categoryId, supplierId, 8, 25m, DateOnly.FromDateTime(DateTime.Now));

            var products = service.GetAllProducts();

            Assert.IsTrue(products.Any(p => p.Name == "Product1"));
            Assert.IsTrue(products.Any(p => p.Name == "Product2"));

            foreach (var p in products.Where(p => p.Name == "Product1" || p.Name == "Product2").ToList())
            {
                service.DeleteProduct(p.ProductId);
            }
        }

        [Test]
        public void GetProductById_ShouldReturnCorrectProduct()
        {
            var categoryId = 1;
            var supplierId = 1;

            service.AddProduct("SpecificProduct", categoryId, supplierId, 7, 18m, DateOnly.FromDateTime(DateTime.Now));
            var products = service.GetAllProducts();
            var id = products[products.Count - 1].ProductId;

            var product = service.GetProductById(id);
            Assert.IsNotNull(product);
            Assert.AreEqual("SpecificProduct", product.Name);

            service.DeleteProduct(id);
        }
    }
}
