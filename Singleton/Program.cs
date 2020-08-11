using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            InMemoryDatabase db = InMemoryDatabase.getInstance();

            db.AddClient("Franco");
            db.AddClient("Perdro");
            db.AddClient("Pablo");
            db.AddClient("Facundo");

            foreach (var client in db.GetClients())
            {
                Console.WriteLine(client);
            }
        }
    }
}
