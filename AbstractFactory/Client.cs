using AbstractFactory.Factories;
using AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public Client()
        {
        }

        public IPhone Phone { get; set; }
        public IPhone SmartPhone { get; set; }
        public Region Region { get; set; }

        public void createMyPhone(AbstractProductFactory factory)
        {
            Phone = factory.CreatePhone();
            SmartPhone = factory.CreateSmartPhone();
        }
    }
}

