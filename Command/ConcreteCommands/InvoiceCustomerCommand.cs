namespace Command
{
    public class InvoiceCustomerCommand : BaseCommand
    {
        private readonly Customer c;
        private readonly decimal amount;

        public InvoiceCustomerCommand(Customer c, decimal amount)
        {
            this.c = c;
            this.amount = amount;
        }
        public override void Execute()
        {
            CustomerRepository.Invoice(c, amount);
        }

        public override void Undo()
        {
            CustomerRepository.UndoInvoice(c, amount);
        }
    }
}




