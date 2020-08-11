namespace FactoryMethod
{
    public abstract class Creator
    { 
        public abstract IProduct CreateProduct();
        public abstract IProduct CreateEnhancedProduct();
    }
}
