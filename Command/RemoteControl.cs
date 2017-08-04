using CommandPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class RemoteControl
    {
        private const int NUMBER_OF_SLOTS = 6;
        private ICommand[] _commands = new ICommand[NUMBER_OF_SLOTS];
        private Stack<ICommand> _prevCommands = new Stack<ICommand>();

        public RemoteControl()
        {
            for (int i = 0; i < NUMBER_OF_SLOTS; i++)
                _commands[i] = new NoCommand();            
        }

        public void SetCommand(int slot, ICommand command)
        {
            _commands[slot] = command;
        }

        public void Run(int slot)
        {
            _commands[slot].Execute();
            _prevCommands.Push(_commands[slot]);
        }

        public void Undo()
        {
            if(_prevCommands.Count > 0)
            {
                var lastCommand = _prevCommands.Pop();
                lastCommand.Undo();
            }
        }


        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for(int i=0; i<NUMBER_OF_SLOTS; i++)
            {
                builder.Append(_commands[i].GetType().ToString());
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

    }
}
