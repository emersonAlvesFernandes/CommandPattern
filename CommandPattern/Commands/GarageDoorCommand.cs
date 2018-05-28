using CommandPattern.Commands.Contracts;
using CommandPattern.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Commands
{
    public class GateOpenCommand : ICommand
    {
        private readonly Gate _garageDoor;

        public GateOpenCommand(Gate garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
        }

        public void Undo()
        {
            _garageDoor.Close();
        }
    }
}
