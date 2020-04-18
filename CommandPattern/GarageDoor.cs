using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class GarageDoor
    {
        private bool IsOpen;

        public void OpenDoor()
        {
            IsOpen = true;
            Console.WriteLine("Door is open!");
        }

        public void CloseDoor()
        {
            IsOpen = false;
            Console.WriteLine("Door is closed!");
        }
        public bool DoorIsOpen() => IsOpen;
    }
}
