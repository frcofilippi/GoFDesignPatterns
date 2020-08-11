using System;

namespace Command
{
    public class RegisterCustomerCommand : BaseCommand
    {
        private readonly Customer customer;

        public RegisterCustomerCommand (Customer customer)
        {
            this.customer = customer;
        }
        public override void Execute()
        {
            CustomerRepository.CreateCustomer(customer);
        }

        public override void Undo()
        {
            CustomerRepository.RemoveCustomer(customer);
        }
    }
}




