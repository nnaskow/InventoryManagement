namespace ServicesTests;
using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;

[TestFixture]
public class TransactionServiceTests
{
    private TransactionService service = new TransactionService();
    private ProductService productService = new ProductService();

    [Test]
    public void AddTransaction_IN_ShouldIncreaseProductQuantity()
    {
        var product = productService.GetAllProducts().First();
        int originalQty = (int)product.Quantity;

        service.AddTransaction(product.ProductId, "IN", 5, DateOnly.FromDateTime(DateTime.Now));

        var updated = productService.GetProductById(product.ProductId);
        Assert.AreEqual(originalQty + 5, updated.Quantity);

        var transaction = service.GetAllTransactions()
            .LastOrDefault(t => t.ProductId == product.ProductId && t.TransactionType == "IN" && t.Quantity == 5);
        Assert.IsNotNull(transaction);

        service.RemoveTransaction(transaction.TransactionId);

        var finalProduct = productService.GetProductById(product.ProductId);
        Assert.AreEqual(originalQty, finalProduct.Quantity);
    }

    [Test]
    public void AddTransaction_OUT_ShouldDecreaseProductQuantity()
    {
        var product = productService.GetAllProducts().First();

        service.AddTransaction(product.ProductId, "IN", 10, DateOnly.FromDateTime(DateTime.Now));
        var originalQty = productService.GetProductById(product.ProductId).Quantity;

        service.AddTransaction(product.ProductId, "OUT", 3, DateOnly.FromDateTime(DateTime.Now));

        var updated = productService.GetProductById(product.ProductId);
        Assert.AreEqual(originalQty - 3, updated.Quantity);

        var transaction = service.GetAllTransactions()
            .LastOrDefault(t => t.ProductId == product.ProductId && t.TransactionType == "OUT" && t.Quantity == 3);
        Assert.IsNotNull(transaction);
    }

    [Test]
    public void AddTransaction_InvalidProduct_ShouldNotAddTransaction()
    {
        int invalidProductId = -1;
        service.AddTransaction(invalidProductId, "IN", 5, DateOnly.FromDateTime(DateTime.Now));

        var result = service.GetAllTransactions()
            .Where(t => t.ProductId == invalidProductId).ToList();

        Assert.AreEqual(0, result.Count);
    }

    [Test]
    public void GetAllTransactions_ShouldReturnAll()
    {
        var product = productService.GetAllProducts().First();

        service.AddTransaction(product.ProductId, "IN", 2, DateOnly.FromDateTime(DateTime.Now));
        service.AddTransaction(product.ProductId, "OUT", 1, DateOnly.FromDateTime(DateTime.Now));

        var transactions = service.GetAllTransactions();

        Assert.IsTrue(transactions.Any(t => t.ProductId == product.ProductId && t.TransactionType == "IN" && t.Quantity == 2));
        Assert.IsTrue(transactions.Any(t => t.ProductId == product.ProductId && t.TransactionType == "OUT" && t.Quantity == 1));
    }

    [Test]
    public void GetTransactionById_ShouldReturnCorrectTransaction()
    {
        var product = productService.GetAllProducts().First();

        service.AddTransaction(product.ProductId, "IN", 4, DateOnly.FromDateTime(DateTime.Now));

        var lastTransaction = service.GetAllTransactions()
            .Last(t => t.ProductId == product.ProductId && t.TransactionType == "IN" && t.Quantity == 4);

        var fetched = service.GetTransactionById(lastTransaction.TransactionId);

        Assert.IsNotNull(fetched);
        Assert.AreEqual(lastTransaction.TransactionId, fetched.TransactionId);
    }

    [Test]
    public void GetLastTransactions_ShouldReturnRecentTransactions()
    {
        var product = productService.GetAllProducts().First();

        service.AddTransaction(product.ProductId, "IN", 1, DateOnly.FromDateTime(DateTime.Now.AddDays(-2)));
        service.AddTransaction(product.ProductId, "OUT", 2, DateOnly.FromDateTime(DateTime.Now.AddDays(-1)));
        service.AddTransaction(product.ProductId, "IN", 3, DateOnly.FromDateTime(DateTime.Now));

        var lastTwo = service.GetLastTransactions(2);

        Assert.AreEqual(2, lastTwo.Count);
        Assert.IsTrue(lastTwo[0].TransactionDate >= lastTwo[1].TransactionDate);
    }
}


