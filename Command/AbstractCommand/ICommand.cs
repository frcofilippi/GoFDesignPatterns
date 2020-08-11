using System.Linq.Expressions;

namespace Command
{
    public interface ICommand
    {
        public CustomerRepository CustomerRepository { get; set; }
        void Execute();
        void Undo();
    }
}




