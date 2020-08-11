using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factories
{
    public class AmericaPhoneFactory : AbstractProductFactory
    {

        public override IPhone CreatePhone()
        {
            return new AmericaPhone();
        }

        public override IPhone CreateSmartPhone()
        {
            return new AmericaPhone();
        }

    }
}
