using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryProductDal : IProductDal
    {
        protected List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId =1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
            new Product{ProductId =2,CategoryId=2,ProductName="Kalem",UnitPrice=5,UnitsInStock=25},
            new Product{ProductId =3,CategoryId=1,ProductName="Telefon",UnitPrice=1215,UnitsInStock=15},
            new Product{ProductId =4,CategoryId=2,ProductName="Kulaklık",UnitPrice=550,UnitsInStock=25}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           var deletedProduct  = _products.Find(id => id.ProductId == product.ProductId);
            _products.Remove(deletedProduct);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {

            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            var productToUpdate = _products.Find(id => id.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
