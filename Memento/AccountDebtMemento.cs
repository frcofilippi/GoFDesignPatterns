using System;

namespace Memento
{
    /// <summary>
    /// Memento class
    /// </summary>
    public class AccountDebtMemento
    {
        private readonly CustomerAccountDebt debt;

        public AccountDebtMemento(CustomerAccountDebt debt)
        {
            this.debt = debt.Clone();
        }
        public CustomerAccountDebt GetMemento() => debt;

    }



}
