using System;

namespace TemplateMethod
{
    public abstract class PaymentProcessor
    {
        public void ProcessPayment()
        {
            CheckCustomerID();
            CheckCustomerAddress();
            ISPaymentMethodValid(); // this method is abstract and can define the implementation within any class derived from this one
            ConfirmPayment();
        }

        protected abstract string ISPaymentMethodValid();

        private void ConfirmPayment()
        {
            Console.WriteLine("Payment confirmed!");
        }

        private void CheckCustomerAddress()
        {
            Console.WriteLine("AddressChecked!");

        }

        private void CheckCustomerID()
        {
            Console.WriteLine("Customer ID checked!");

        }
    }

    public class CCPaymentProcessor : PaymentProcessor
    {
        protected override string ISPaymentMethodValid()
        {
            return $"Payment method validation: {this.GetType().Name}";
        }
    }

    public class PayPalPaymentProcessor : PaymentProcessor
    {
        protected override string ISPaymentMethodValid()
        {
            return $"Payment method validation: {this.GetType().Name}";
        }
    }
}
