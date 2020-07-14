using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShop.Data;
using BlazorShop.Models;

namespace BlazorShop.Services
{
    public class CategoryService
    {
        private readonly ApplicationDbContext _db;

        public CategoryService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Category GetCategory(int categoryId)
        {
            return _db.Categories.FirstOrDefault(u => u.Id == categoryId);
        }

        public List<Category> GetCategories()
        {
            return _db.Categories.ToList<Category>();
        }

        public bool CreateCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();

            return true;
        }

        public bool UpdateCategory(Category category)
        {
            var ExistingCategory = _db.Categories.FirstOrDefault(u => u.Id == category.Id);
            if (ExistingCategory != null)
            {
                ExistingCategory.Name = category.Name;
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteCategory(Category category)
        {
            var ExistingCategory = _db.Categories.FirstOrDefault(u => u.Id == category.Id);
            if (ExistingCategory != null)
            {
                _db.Remove(category);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}