namespace Command
{
    public abstract class BaseCommand : ICommand
    {
        public CustomerRepository CustomerRepository { get; set; } = CustomerRepository.GetInstance();

        public abstract void Execute();

        public abstract void Undo();
    }
}




