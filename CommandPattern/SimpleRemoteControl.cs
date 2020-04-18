using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class SimpleRemoteControl
    {
        private ICommand slot;

        public void SetCommand(ICommand command) => slot = command;

        public void ButtonWasPressed() => slot.Execute();
    }
}
