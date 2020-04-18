using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class GarageDoorOpenCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            if (CanExecute())
            {
                garageDoor.OpenDoor();
            }
        }

        public void Undo() => garageDoor.CloseDoor();

        public bool CanExecute() => !garageDoor.DoorIsOpen();
    }
}
