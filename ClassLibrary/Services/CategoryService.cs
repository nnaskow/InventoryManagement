using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.Services
{
    /// <summary>
    /// Услуга за управление на категории в системата за управление на инвентара.
    /// </summary>
    public class CategoryService
    {
        /// <summary>
        /// Добавя нова категория.
        /// </summary>
        /// <param name="name">Името на новата категория.</param>
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

        /// <summary>
        /// Връща списък с всички категории.
        /// </summary>
        /// <returns>Списък с обекти от тип Category.</returns>
        public List<Category> GetAllCategories()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.ToList();
            }
        }

        /// <summary>
        /// Връща категория по зададено ID.
        /// </summary>
        /// <param name="categoryId">Идентификатор на категорията.</param>
        /// <returns>Категорията или null, ако не съществува.</returns>
        public Category GetCategoryById(int categoryId)
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.FirstOrDefault(c => c.CategoryId == categoryId);
            }
        }

        /// <summary>
        /// Редактира името на съществуваща категория.
        /// </summary>
        /// <param name="categoryId">Идентификатор на категорията.</param>
        /// <param name="newName">Новото име на категорията.</param>
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

        /// <summary>
        /// Изтрива категория по зададено ID.
        /// </summary>
        /// <param name="categoryId">Идентификатор на категорията.</param>
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

        /// <summary>
        /// Връща списък с всички идентификатори на категории.
        /// </summary>
        /// <returns>Списък с цели числа, представляващи ID на категориите.</returns>
        public List<int> GetAllCategoryIds()
        {
            using (var _context = new InventoryManagementContext())
            {
                return _context.Categories.Select(c => c.CategoryId).ToList();
            }
        }
    }
}
