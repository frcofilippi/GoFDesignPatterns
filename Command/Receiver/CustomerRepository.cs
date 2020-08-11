using System;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class CustomerRepository
    {
        private static CustomerRepository _Instance = null;
        private static List<Customer> customers;

        private CustomerRepository()
        {
            customers = new List<Customer>();
        }

        public static CustomerRepository GetInstance()
        {
            if (_Instance == null)
            {
                _Instance = new CustomerRepository();
            }
            return _Instance;
        }

        public void CreateCustomer(Customer c)
        {
            c.Id = Guid.NewGuid();
            customers.Add(c);
        }

        public void Invoice(Customer c, decimal amount)
        {
            c.AddAmount(amount);
        }

        public void UndoInvoice(Customer c, decimal amount)
        {
            c.Discount(amount);
        }

        public void RemoveCustomer(Customer x)
        {
            customers.Remove(x);
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }
    }
}




