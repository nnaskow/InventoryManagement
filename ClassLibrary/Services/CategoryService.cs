using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    public class CategoryService
    {
        
        public void AddCategory(string name)
        {
            var category = new Category
            {
                Name = name
            };
            using (var _context = new InventoryManagementContext())
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
            }
        }

        public List<Category> GetAllCategories()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.ToList();
            }
        }

        public Category GetCategoryById(int categoryId)
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            }
        }

        public void EditCategory(int categoryId, string newName)
        {
            using (var _context = new InventoryManagementContext())
            {
                var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                if (category != null)
                {
                    category.Name = newName;
                    _context.SaveChanges();
                }
            }
        }

        public void DeleteCategory(int categoryId)
        {
            using (var _context = new InventoryManagementContext())
            {
                var category = _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);

                if (category != null)
                {
                    _context.Categories.Remove(category);
                    _context.SaveChanges();
                }
            }
        }

        public List<int> GetAllCategoryIds()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.Select(c => c.CategoryId).ToList();
            }
        }
    }
}
