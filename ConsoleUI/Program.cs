using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductService productService = new ProductManager(new InMemoryProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
