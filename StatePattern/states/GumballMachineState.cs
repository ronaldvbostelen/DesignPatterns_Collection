using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.states
{
    public abstract class GumballMachineState
    {
        protected GumBallMachine gumBallMachine;

        protected GumballMachineState(GumBallMachine gumBallMachine)
        {
            this.gumBallMachine = gumBallMachine;
        }
    }
}
