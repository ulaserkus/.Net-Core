using System;
using System.Collections.Generic;
using web_app.entity;

namespace web_app.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {

        List<Product> GetPopularProducts();


       List<Product> GetProductByCategory(string name);


    }
}
