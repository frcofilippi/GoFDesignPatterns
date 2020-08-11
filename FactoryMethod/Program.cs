using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {

            Creator productCreator = new ConcreteCreator();

            List<IProduct> productList = new List<IProduct>();

            IProduct prod = productCreator.CreateProduct();
            IProduct prod2 = productCreator.CreateEnhancedProduct();
            productList.Add(prod);
            productList.Add(prod2);

            foreach (var p in productList)
            {
                PrintProductInformation(p);
            }
            
        }

        private static void PrintProductInformation(IProduct prod)
        {
            Console.WriteLine(prod.GetProductInfo());
        }
    }
}
