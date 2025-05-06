using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class CategoryService
    {
        private readonly InventoryManagementContext _context;

        public CategoryService()
        {
            _context = new InventoryManagementContext();
        }

        public void AddCategory(string name)
        {
            var category = new Category
            {
                Name = name
            };

            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
        }

        public void EditCategory(int categoryId, string newName)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

            if (category != null)
            {
                category.Name = newName;
                _context.SaveChanges();
            }
        }

        public void DeleteCategory(int categoryId)
        {
            var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }

        public List<int> GetAllCategoryIds()
        {
            return _context.Categories.Select(c => c.CategoryId).ToList();
        }
    }
}
