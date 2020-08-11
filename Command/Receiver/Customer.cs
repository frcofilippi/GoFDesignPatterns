using System;

namespace Command
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        private static decimal totalOwed = 0;

        public void AddAmount(decimal amount)
        {
            totalOwed += amount;
        }

        public void Discount(decimal amount)
        {
            totalOwed -= amount;
        }

        public decimal GetTotalOwed()
        {
            return totalOwed;
        }
    }
}




