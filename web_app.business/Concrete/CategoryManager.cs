using System;
using System.Collections.Generic;
using web_app.business.Abstract;
using web_app.data.Abstract;
using web_app.entity;

namespace web_app.business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryRepository CategoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return CategoryRepository.GetAll();
        }

        public Category GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
