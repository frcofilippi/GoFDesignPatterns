using System;
using System.Runtime.CompilerServices;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // This pattern tries to avoid the inherent costs of using the new word for crating the object by adding the ability to clone
            Console.WriteLine("Hello World!");

            //Modelo product
            ProductA productPrototye = new ProductA(); // the original copy
            PrintProductIfno(productPrototye);
            Console.WriteLine("CLONING...");

            //this pattern makes sense when the creation process is heavy 
            
            var prod2 = productPrototye.Clone() as ProductA;
            PrintProductIfno(prod2);

            Console.Read();

        }

        private static void PrintProductIfno(ProductA productPrototye)
        {
            Console.WriteLine($"This is the prototype. " +
                            $"Id: {productPrototye.Id} - Name: {productPrototye.Name}");
        }
    }

    public abstract class AbstractProduct
    {
        public abstract AbstractProduct Clone();
    }

    public class ProductA : AbstractProduct
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "default";

        public override AbstractProduct Clone()
        {
            return (ProductA)this.MemberwiseClone();
        }
    }

}
