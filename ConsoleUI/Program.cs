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

            ProductManager productManager = new ProductManager(new EfProductDal(),new EfCategoryDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            foreach (var category in productManager.GetAllByCategory())
            {
                Console.WriteLine(category.CategoryName);
            }

            foreach (var product in productManager.GetAllByProduct())
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}
