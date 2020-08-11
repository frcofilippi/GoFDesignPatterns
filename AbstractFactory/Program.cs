using AbstractFactory.Factories;
using System;
using System.ComponentModel.DataAnnotations;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem is I need to abstract the complete process of creating an object 
            // by only indicating the abstract factory I would like to use
            // All products implements same interface
            Console.WriteLine("Hello World!");

            Console.WriteLine("We got a cliente from America, then we need to create phones for America");
            Client c = new Client();
            c.Region = Region.Africa;
            if (c.Region == Region.America)
            {
                c.createMyPhone(new AmericaPhoneFactory());
            }
            else
            {
                c.createMyPhone(new AfricaPhoneFactory());
            }

            Console.WriteLine($"I'm from {c.Region} and my phone is {c.Phone.GetType().Name}");
            Console.Read();
        }
    }
}