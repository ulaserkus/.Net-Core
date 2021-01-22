using System;
using System.Collections.Generic;
using web_app.entity;

namespace web_app.business.Abstract
{
    public interface IProductService
    {


        Product GetProductById(int id);

        List<Product> GetAll();

        List<Product> GetProductsByCategory(string category);


        void Create(Product entity);

        void Update(Product entity);

        void Delete(Product entity);

    }
}
