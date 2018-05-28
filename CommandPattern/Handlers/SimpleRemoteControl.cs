using CommandPattern.Commands.Contracts;

namespace CommandPattern.Handlers
{
    public class SimpleRemoteControl
    {
        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;
        private ICommand _undoCommand;

        private ICommand _slot;

        public SimpleRemoteControl(int commandNumber)
        {
            _onCommands = new ICommand[commandNumber];
            _offCommands = new ICommand[commandNumber];

            //var noCommand = new NoCommand();
            //for(int i = 0; i < commandNumber; i++)
            //{
            //    _onCommands[i] = onCommand;
            //    _ofCommands[i] = offCommand;
            //}
        }

        
        public void SetCommand(ICommand slot)
        {
            _slot = slot;            
        }
        public void ButtonPressed()
        {
            _slot.Execute();
        }
        public void UndoButtonPressed()
        {
            _slot.Undo();
        }


        public void SetCommand(int slot, ICommand onCommand, ICommand offComand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offComand;
        }
        public void OnButtonPressed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }
        public void OffButtonPressed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }
        //public void UndoButtonPressed()
        //{
        //    _undoCommand.Undo();
        //}

    }
}
