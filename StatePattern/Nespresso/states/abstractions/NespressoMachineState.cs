using System;

namespace StatePattern.Nespresso.states
{
    public abstract class NespressoMachineState : IState
    {
        protected NespressoMachine nespressoMachine;

        public NespressoMachineState(NespressoMachine nespressoMachine)
        {
            this.nespressoMachine = nespressoMachine;
        }

        public virtual void RefillWaterReservoir(int amount) => nespressoMachine.WaterAmount = amount;
        public virtual void EmptyBin() => nespressoMachine.CupsInBin = 0;

        public virtual void TurnHandle()
        {
            if (nespressoMachine.HandleDown)
            {
                Console.WriteLine("Handle up.");
            }
            else
            {
                Console.WriteLine("Handle down.");
            }

            nespressoMachine.HandleDown = !nespressoMachine.HandleDown;
        } 
        public abstract void InsertCup();
        public abstract void PressButton();
    }
}