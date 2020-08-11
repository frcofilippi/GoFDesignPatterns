using AbstractFactory.Products;

namespace AbstractFactory
{
    public abstract class AbstractProductFactory
    {
        public abstract IPhone CreatePhone();
        public abstract IPhone CreateSmartPhone();
    }
}
