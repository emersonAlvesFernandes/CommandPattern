using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands.Contracts
{
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}
