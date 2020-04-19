using System;

namespace StatePattern.Nespresso.states
{
    public class NoCupState : NespressoMachineState
    {
        public NoCupState(NespressoMachine nespressoMachine) : base(nespressoMachine)
        {
        }
        
        public override void InsertCup()
        {
            if (nespressoMachine.HandleDown)
            {
                Console.WriteLine("Put the handle up first");
            }
            else
            {
                Console.WriteLine("Inserted a coffee cup");
                nespressoMachine.CurrentState = nespressoMachine.CupState;
            }
        }

        public override void PressButton()
        {
            Console.WriteLine("No Dice. No coffee cup.");
        }
    }
}