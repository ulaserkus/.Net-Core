using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using web_app.data.Abstract;
using web_app.entity;

namespace web_app.data.Concrete.EfCore
{
    public class EfCoreProductRepository : EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {

                return context.Products.ToList();
            }
        }

        public List<Product> GetProductByCategory(string name)
        {
           using(var context = new ShopContext())
            {

                var products = context.Products.AsQueryable();
                if (!string.IsNullOrEmpty(name))
                {
                    products = products
                               .Include(i => i.ProductCategories)
                               .ThenInclude(i => i.Category)
                               .Where(i => i.ProductCategories.Any(a => a.Category.Url == name));

                    
                }
                return products.ToList();

            }
        }
    }
}
