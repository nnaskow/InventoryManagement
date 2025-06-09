namespace ServicesTests;
using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Linq;

[TestFixture]
public class SupplierServiceTests
{
    private SupplierService service = new SupplierService();

    [Test]
    public void AddSupplier_ShouldAddSupplier()
    {
        service.AddSupplier("TestSupplier", "TestContact", "111", "test@mail.com");

        var supplier = service.GetAllSuppliers().FirstOrDefault(s => s.Name == "TestSupplier");
        Assert.IsNotNull(supplier);
        Assert.AreEqual("TestContact", supplier.ContactName);
        Assert.AreEqual("111", supplier.Phone);
        Assert.AreEqual("test@mail.com", supplier.Email);

        service.DeleteSupplier(supplier.SupplierId);
    }

    [Test]
    public void GetSupplierById_ShouldReturnSupplier()
    {
        service.AddSupplier("TempSupplier", "Contact", "222", "temp@mail.com");
        var supplier = service.GetAllSuppliers().First(s => s.Name == "TempSupplier");

        var fetched = service.GetSupplierById(supplier.SupplierId);
        Assert.IsNotNull(fetched);
        Assert.AreEqual("TempSupplier", fetched.Name);

        service.DeleteSupplier(supplier.SupplierId);
    }

    [Test]
    public void EditSupplier_ShouldUpdateSupplier()
    {
        service.AddSupplier("EditMe", "OldContact", "333", "old@mail.com");
        var supplier = service.GetAllSuppliers().First(s => s.Name == "EditMe");

        service.EditSupplier(supplier.SupplierId, "Edited", "NewContact", "444", "new@mail.com");
        var updated = service.GetSupplierById(supplier.SupplierId);

        Assert.AreEqual("Edited", updated.Name);
        Assert.AreEqual("NewContact", updated.ContactName);
        Assert.AreEqual("444", updated.Phone);
        Assert.AreEqual("new@mail.com", updated.Email);

        service.DeleteSupplier(updated.SupplierId);
    }

    [Test]
    public void DeleteSupplier_ShouldRemoveSupplier()
    {
        service.AddSupplier("ToDelete", "Contact", "555", "delete@mail.com");
        var supplier = service.GetAllSuppliers().First(s => s.Name == "ToDelete");

        service.DeleteSupplier(supplier.SupplierId);
        var deleted = service.GetSupplierById(supplier.SupplierId);

        Assert.IsNull(deleted);
    }

    [Test]
    public void GetAllSuppliers_ShouldReturnAll()
    {
        service.AddSupplier("S1", "C1", "111", "s1@mail.com");
        service.AddSupplier("S2", "C2", "222", "s2@mail.com");

        var suppliers = service.GetAllSuppliers();
        Assert.IsTrue(suppliers.Any(s => s.Name == "S1"));
        Assert.IsTrue(suppliers.Any(s => s.Name == "S2"));

        foreach (var s in suppliers.Where(s => s.Name == "S1" || s.Name == "S2"))
            service.DeleteSupplier(s.SupplierId);
    }
}


