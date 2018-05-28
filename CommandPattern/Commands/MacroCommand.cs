using CommandPattern.Commands.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach(var c in _commands)
            {
                c.Execute();
            }
        }

        public void Undo()
        {
            foreach (var c in _commands)
            {
                c.Undo();
            }
        }
    }
}
