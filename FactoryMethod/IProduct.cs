using System;

namespace FactoryMethod
{
    public interface IProduct
    {
        Guid Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }

        string GetProductInfo();
        

    }
}
