using System;

namespace Strategy
{
    public class PaymentProcessor
    {
        private readonly IPaymentProcessorStrategy _processorStrategy;

        public PaymentProcessor(IPaymentProcessorStrategy processorStrategy)
        {
            _processorStrategy = processorStrategy;
        }

        public bool ProcessPayment()
        {
            return _processorStrategy.Process();
        }

        //public void SwitchStrategy(IPaymentProcessorStrategy strategy)
        //{
        //    _processorStrategy = strategy;
        //}
    }
}
