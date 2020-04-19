using System;

namespace StatePattern.Nespresso.states
{
    public class FullBinState : NespressoMachineState, IState
    {
        public FullBinState(NespressoMachine nespressoMachine) : base(nespressoMachine)
        {
        }

        public override void InsertCup()
        {
            Console.WriteLine("Full bin. You cant do that right now.");
        }

        public override void PressButton()
        {
            Console.WriteLine("Full bin. You cant do that right now.");
        }

        public override void EmptyBin()
        {
            nespressoMachine.CurrentState = nespressoMachine.NoCupState;
            base.EmptyBin();
        }
    }
}