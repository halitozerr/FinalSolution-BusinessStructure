using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager categoryManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            Product product = new Product { CategoryId = 2, ProductName = "Ozztech Ayakkabı", UnitPrice = 1500, UnitsInStock = 132 };

            foreach (var item in categoryManager.GetByUnitPrice(15,20).Data)
            {
                Console.WriteLine(item.UnitPrice);
            }
            Console.WriteLine("==========================================");
            foreach (var item in categoryManager.GetProductDetails().Data)
            {
                Console.WriteLine(item.CategoryName + " - " + item.ProductName);
            }
            

           
          
            

        }
    }
}
