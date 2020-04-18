using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    abstract class Device
    {
        protected bool On;

        public void TurnOn() => On = true;

        public void TurnOff() => On = false;
    }
}
