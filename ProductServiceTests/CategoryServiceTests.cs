namespace ServicesTests;
using InventoryManagement.Models;
using InventoryManagement.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;
using Microsoft.EntityFrameworkCore;

    [TestFixture]
    public class CategoryServiceTests
    {
        private CategoryService service = new CategoryService();

        [Test]
        public void AddCategory_ShouldAddCorrectly()
        {
            service.AddCategory("Breakfast");
            var categories = service.GetAllCategories();

            Assert.AreEqual("Breakfast", categories[categories.Count-1].Name);
            service.DeleteCategory(categories[categories.Count - 1].CategoryId);
        }

    [Test]
    public void EditCategory_ShouldChangeTheName()
    {
        service.AddCategory("OldName");
        var id = service.GetAllCategoryIds();

        service.EditCategory(id[id.Count - 1], "NewName");

        var edited = service.GetCategoryById(id[id.Count - 1]);
        Assert.AreEqual("NewName", edited.Name);

        service.DeleteCategory(id[id.Count - 1]);
    }

    [Test]
    public void DeleteCategory_ShouldRemoveIt()
    {
        service.AddCategory("ToDelete");
        var id = service.GetAllCategoryIds();

        service.DeleteCategory(id[id.Count-1]);
        var result = service.GetCategoryById(id[id.Count - 1]);

        Assert.IsNull(result);
    }

    [Test]
    public void GetAllCategories_ShouldReturnAll()
    {
        service.AddCategory("Bread");
        service.AddCategory("Milk");

        var list = service.GetAllCategories();
        Assert.IsTrue(list.Any(c => c.Name == "Bread"));
        Assert.IsTrue(list.Any(c => c.Name == "Milk"));

        foreach (var cat in list.Where(c => c.Name == "Bread" || c.Name == "Milk").ToList())
        {
            service.DeleteCategory(cat.CategoryId);
        }
    }

    [Test]
    public void GetCategoryById_ShouldReturnCorrectCategory()
    {
        service.AddCategory("Juice");
        var id = service.GetAllCategoryIds();

        var cat = service.GetCategoryById(id[id.Count - 1]);
        Assert.IsNotNull(cat);
        Assert.AreEqual("Juice", cat.Name);

        service.DeleteCategory(id[id.Count - 1]);
    }
}
