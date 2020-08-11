using System;

namespace FactoryMethod
{
    public class EnhancedProduct : IProduct
    {

        public EnhancedProduct(string name, decimal price)
        {
            Name = name;
            Price = price;
            Expensive = (price > 500);
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Expensive { get; set; }

        public string GetProductInfo()
        {
            return $"Product: {Id} - {Name}  | Price: {Price} | Expensive: {Expensive}";
        }
    }
}
