using System;

namespace Memento
{
    /// <summary>
    /// This is the originator
    /// </summary>
    public class CustomerAccountDebt
    {
        public Guid Id { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }

        public CustomerAccountDebt()
        {
            Id = Guid.NewGuid();
        }

        public AccountDebtMemento SaveMemento()
        {
            return (new AccountDebtMemento(this));
        }

        public void Rollback(AccountDebtMemento mem)
        {
            var memento =mem.GetMemento();
            this.Id = memento.Id;
            this.Customer = memento.Customer;
            this.Amount = memento.Amount;
        }

        public CustomerAccountDebt Clone()
        {
            return this.MemberwiseClone() as CustomerAccountDebt;
        }
    }

}
