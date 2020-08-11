using System;

namespace Builder
{

    // Builder is a creational design pattern that lets you 
    // construct complex objects step by step
    //.The pattern allows you to produce different types and representations of an 
    // object using the same construction code.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var director = new BuilderDirector(); 
            // could create another SpecialBuilder to buil different type of object that implements the same interfaz and it would be 
            // builder + abstract factory
            PrintBookInfo(director.Build());
        }

        private static void PrintBookInfo(IBook book)
        {
            Console.WriteLine($"ID: {book.Id} - Title: {book.Name}");
        }
    }

}
