using AbstractFactory.Products;
using System;

namespace AbstractFactory
{
    public class AfricaPhoneFactory : AbstractProductFactory
    {
        public override IPhone CreatePhone()
        {
            return new AfricaPhone();
        }

        public override IPhone CreateSmartPhone()
        {
            return new AfricaSmartPhone();
        }
    }
}