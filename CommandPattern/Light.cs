using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Light
    {
        private bool on;

        public void TurnOn()
        {
            if (!on) on = true;
            Console.WriteLine("Light is on!");
        }

        public void TurnOff()
        {
            if (on) on = false;
            Console.WriteLine("Light is off!");
        }

        public bool IsOn() => on;
    }
}
