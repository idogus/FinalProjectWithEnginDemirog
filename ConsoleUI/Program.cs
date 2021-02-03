using Business.Abstract;
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
            IProductService productService = new ProductManager(new EfProductDal());

            foreach (var product in productService.GetByUnitPrice(50, 5000))
            {
                Console.WriteLine(product.ProductName + " " + product.CategoryId + " " + product.UnitPrice);
            }
        }
    }
}
