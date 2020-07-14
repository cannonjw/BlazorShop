using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorShop.Data;
using BlazorShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _db;

        public ProductService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Product GetProduct(int productId)
        {
            return _db.Products.FirstOrDefault(u => u.Id == productId);
        }

        public List<Category> GetCategoryList()
        {
            return _db.Categories.ToList<Category>();
        }


        public List<Product> GetProducts()
        {
            return _db.Products.Include(x => x.Category).ToList<Product>();
        }

        public bool CreateProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();

            return true;
        }

        public bool UpdateProduct(Product product)
        {
            var ExistingProduct = _db.Products.FirstOrDefault(u => u.Id == product.Id);
            if (ExistingProduct != null)
            {
                if (product.Image == null)
                {
                    product.Image = ExistingProduct.Image;
                }
                _db.Products.Update(product);
                _db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteProduct(Product product)
        {
            var ExistingProduct = _db.Products.FirstOrDefault(u => u.Id == product.Id);
            if (ExistingProduct != null)
            {
                _db.Remove(product);
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