namespace Strategy
{
    public interface IPaymentProcessorStrategy
    {
        bool Process();
    }

    public class PaymentProcessorA : IPaymentProcessorStrategy
    {
        public bool Process()
        {
            return true;
        }
    }
    public class PaymentProcessorB : IPaymentProcessorStrategy
    {
        public bool Process()
        {
            return false;
        }
    }
}
