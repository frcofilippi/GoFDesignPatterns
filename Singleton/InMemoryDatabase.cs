using System.Collections.Generic;

namespace Singleton
{
    public class InMemoryDatabase
    {
        private static InMemoryDatabase Instance = null;
        private List<string> clients;

        private InMemoryDatabase()
        {
            clients = new List<string>();
        }

        public static InMemoryDatabase getInstance()
        {
            if (Instance == null)
                Instance = new InMemoryDatabase();
            return Instance;
        }

        public List<string> GetClients()
        {
            return clients;
        }

        public void AddClient(string name)
        {
            clients.Add(name);
        }
    }
}
