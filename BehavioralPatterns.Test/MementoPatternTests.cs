using Memento;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BehavioralPatterns.Test
{
    [Collection("Memento")]
    public class MementoPatternTests
    {
        [Fact]
        public void ShouldRestoreToPreviousState()
        {
            // the test itself would plat the role of the caretaker
            //let's imagine a debt in a bank account
            List<AccountDebtMemento> list = new List<AccountDebtMemento>();
            var c1 = new Customer() { Id = Guid.NewGuid(), Name = "Franco Filippi" };
            var c2 = new Customer() { Id = Guid.NewGuid(), Name = "Federico Filippi" };
            var debt = new CustomerAccountDebt();
            debt.Amount = 10;
            debt.Customer = c1;

            // need to move the list to a caretaker class
            var memento = debt.SaveMemento();
            list.Add(memento);

            // make some changes

            debt.Amount = 15.25m;

            Assert.True(debt.Amount == 15.25m);

            debt.Rollback(memento);

            Assert.True(debt.Amount == 10);

        }
    }
}
