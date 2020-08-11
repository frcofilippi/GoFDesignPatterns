using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace BehavioralPatterns.Test
{
    [Collection("Command")]
    public class CommandPatternTest
    {


        [Fact]
        public void ShouldAllCommandsBeStored()
        {
            var controller = new CustomerController();
            var customer1 = new Customer() { Name = "Franco" };
            var customer2 = new Customer() { Name = "Federico" };

            ICommand addCustomer = new RegisterCustomerCommand(customer1);
            ICommand invoiceCommand = new InvoiceCustomerCommand(customer1, 10);

            controller.GetCommandAt(controller.AddCommand(addCustomer)).Execute();
            controller.GetCommandAt(controller.AddCommand(invoiceCommand)).Execute();


            var expected = 2;

            Assert.True(expected == controller.GetCommands().Count);

        }

        [Fact]
        public void ShouldInvoiceCustomerExecuteWork()
        {
            var controller = new CustomerController();
            var customer1 = new Customer() { Name = "Franco" };
            var customer2 = new Customer() { Name = "Federico" };

            ICommand addCustomer = new RegisterCustomerCommand(customer1);
            ICommand invoiceCommand = new InvoiceCustomerCommand(customer1, 10.23m);


            controller.GetCommandAt(controller.AddCommand(addCustomer)).Execute();
            controller.GetCommandAt(controller.AddCommand(invoiceCommand)).Execute();

            Assert.True(CustomerRepository.GetInstance().GetCustomers().First(c => c.Id == customer1.Id).GetTotalOwed() == 10.23m);
        }

        [Fact]
        public void ShouldRegisterCustomerExecuteWork()
        {
            var controller = new CustomerController();
            var customer1 = new Customer() { Name = "Franco" };
            var customer2 = new Customer() { Name = "Federico" };

            ICommand addCustomer = new RegisterCustomerCommand(customer1);

            decimal amount = 10.20m;
            controller.GetCommandAt(controller.AddCommand(addCustomer)).Execute();

            Assert.Contains(customer1, CustomerRepository.GetInstance().GetCustomers());
        }



        [Fact]
        public void ShouldUndoWork()
        {
            var controller = new CustomerController();
            var customer1 = new Customer() { Name = "Franco" };
            var customer2 = new Customer() { Name = "Federico" };

            ICommand addCustomer = new RegisterCustomerCommand(customer1);
            ICommand invoiceCommand = new InvoiceCustomerCommand(customer1, 10.23m);
            var referenceToInvoice = controller.AddCommand(invoiceCommand);

            controller.GetCommandAt(controller.AddCommand(addCustomer)).Execute();
            controller.GetCommandAt(referenceToInvoice).Execute();
            controller.GetCommandAt(referenceToInvoice).Undo();

            Assert.True(CustomerRepository.GetInstance().GetCustomers().First(c => c.Id == customer1.Id).GetTotalOwed() == 0.00m);
        }
    }
}
