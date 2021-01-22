using System;
using System.Collections.Generic;
using web_app.entity;

namespace web_app.business.Abstract
{
    public interface ICategoryService
    {

        Category GetProductById(int id);

        List<Category> GetAll();


        void Create(Category entity);

        void Update(Category entity);

        void Delete(Category entity);
    }
}
