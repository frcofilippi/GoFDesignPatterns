using System;
using System.Collections.Generic;

namespace Command
{
    public class CustomerController
    {
        private List<ICommand> _listOfCommands;

        public CustomerController()
        {
            _listOfCommands = new List<ICommand>();
        }

        public int AddCommand(ICommand command)
        {
            _listOfCommands.Add(command);
            return _listOfCommands.IndexOf(command);
        }

        public void RemoveCommand(int index)
        {
            _listOfCommands.RemoveAt(index);
        }

        public ICommand GetCommandAt(int index)
        {
            return _listOfCommands[index];
        }

        public List<ICommand> GetCommands()
        {
            return _listOfCommands;
        }
    }
}




