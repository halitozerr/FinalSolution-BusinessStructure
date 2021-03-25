using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager categoryManager = new ProductManager(new EfProductDal());


            foreach (var item in categoryManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName + " / " + item.CategoryName);

                
            }

            Console.WriteLine("=====================================================================");

           
          
            

        }
    }
}
