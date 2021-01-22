using System;
using System.Collections.Generic;
using web_app.business.Abstract;
using web_app.data.Abstract;
using web_app.entity;

namespace web_app.business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            this._productRepository = productRepository;

        }

        public void Create(Product entity)
        {

            //iş kurallarını  uygula
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {
          return  _productRepository.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productRepository.GetProductById(id);
        }

        public List<Product> GetProductsByCategory(string category)
        {
            return _productRepository.GetProductByCategory(category);
        }

        public void Update(Product entity)
        {
            _productRepository.Update(entity);
        }

     
    }
}
