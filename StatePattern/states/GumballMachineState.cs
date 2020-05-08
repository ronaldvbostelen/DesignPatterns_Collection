using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.states
{
    public abstract class GumballMachineState
    {
        protected GumBallMachine gumBallMachine;
        private string name;

        protected GumballMachineState(GumBallMachine gumBallMachine, string stateName)
        {
            this.gumBallMachine = gumBallMachine;
            name = stateName;
        }

        public override string ToString() => $"State: {name}";
    }
}
