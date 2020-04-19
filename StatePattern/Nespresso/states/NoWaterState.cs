using System;

namespace StatePattern.Nespresso.states
{
    public class NoWaterState : NespressoMachineState, IState
    {
        public NoWaterState(NespressoMachine nespressoMachine) : base(nespressoMachine)
        {
        }
        
        public override void RefillWaterReservoir(int amount)
        {
            nespressoMachine.CurrentState = nespressoMachine.CupState;
            base.RefillWaterReservoir(amount);
        }

        public override void InsertCup()
        {
            Console.WriteLine("There is a cup already");
        }

        public override void PressButton()
        {
            Console.WriteLine("You cant do that right now");
        }
    }
}