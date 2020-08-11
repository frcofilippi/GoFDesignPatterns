using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Strategy;

namespace BehavioralPatterns.Test
{
    [Collection("Strategy")]
    public class StrategyPatternTests
    {
        [Fact]
        public void ShouldProcessPaymentWithStrategyA()
        {
            IPaymentProcessorStrategy paymentStrategy = new PaymentProcessorA();
            var processor = new PaymentProcessor(paymentStrategy);
            
            Assert.True(processor.ProcessPayment());
        }

        [Fact]
        public void ShouldProcessPaymentWithStrategyB()
        {
            IPaymentProcessorStrategy paymentStrategy = new PaymentProcessorB();
            var processor = new PaymentProcessor(paymentStrategy);

            Assert.False(processor.ProcessPayment());
        }
    }
}
