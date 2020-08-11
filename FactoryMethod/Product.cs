using System;

namespace FactoryMethod
{
    public class Product: IProduct
    {
        public Product()
        {
            Id =Guid.NewGuid();
        }

        public Product(string name, decimal price = 0m) : this()
        {
            Name = name;
            Price = price;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public string GetProductInfo()
        {
            return $"Product: {Id} - {Name}  | Price: {Price}";
        }
    }
}
