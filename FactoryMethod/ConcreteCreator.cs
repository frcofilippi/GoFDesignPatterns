namespace FactoryMethod
{
    public class ConcreteCreator : Creator 
    {
        public override IProduct CreateProduct()
        {
            return new Product("iPhone", 20.30m);
        }

        public override IProduct CreateEnhancedProduct()
        {
            return new EnhancedProduct("iPhone X", 1250.02m);
        }
    }


}
