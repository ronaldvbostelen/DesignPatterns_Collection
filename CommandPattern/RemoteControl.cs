using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CommandPattern
{
    class RemoteControl
    {
        private Action[] onCommands;
        private Action[] offCommands;
        private Action undoCommand;

        public RemoteControl()
        {
            onCommands = new Action[7];
            offCommands = new Action[7];
            undoCommand = null;

            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = new NoCommand().Execute;
                offCommands[i] = new NoCommand().Execute;
            }
        }

        public void SetCommand(int slot, Action onCommand, Action offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            onCommands[slot]();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            offCommands[slot]();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonPress() => undoCommand();

    }
}
