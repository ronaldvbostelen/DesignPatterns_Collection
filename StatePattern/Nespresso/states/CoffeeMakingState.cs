using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Nespresso.states
{
    class CoffeeMakingState : NespressoMachineState
    {
        public CoffeeMakingState(NespressoMachine nespressoMachine) : base(nespressoMachine)
        {
        }

        public override void TurnHandle() => GeneralError();
        public override void InsertCup() => GeneralError();
        public override void PressButton() => GeneralError();

        private void GeneralError() => Console.WriteLine("You cant do that right now");
    }
}
