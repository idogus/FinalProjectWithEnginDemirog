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
            //ProductTest();
            //CategoryTest();
            ProductDetailTest();
        }

        private static void ProductDetailTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var productDetailDto in productManager.GetProductDetails())
            {
                Console.WriteLine(productDetailDto.ProductName + " - " + productDetailDto.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            IProductService productService = new ProductManager(new EfProductDal());

            foreach (var product in productService.GetByUnitPrice(50, 5000))
            {
                Console.WriteLine(product.ProductName + " " + product.CategoryId + " " + product.UnitPrice);
            }
        }
    }
}
