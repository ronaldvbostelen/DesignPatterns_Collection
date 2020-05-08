using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Nespresso.states
{
    class CupState : NespressoMachineState
    {
        public CupState(NespressoMachine nespressoMachine) : base(nespressoMachine)
        {
        }
        
        public override void InsertCup()
        {
            Console.WriteLine("There is a cup already.");
        }

        public override void TurnHandle()
        {
            base.TurnHandle();

            if (!nespressoMachine.HandleDown)
            {
                nespressoMachine.CupsInBin++;
                if (nespressoMachine.CupsInBin == nespressoMachine.MaxAmountCupsInBin)
                {
                    Console.WriteLine("Bin is full");
                    nespressoMachine.CurrentState = nespressoMachine.FullBinState;
                }
                else
                {
                    nespressoMachine.CurrentState = nespressoMachine.NoCupState;
                }
            }
        }

        public override void PressButton()
        {
            if (nespressoMachine.HandleDown && nespressoMachine.WaterAmount >= nespressoMachine.WaterPerCup)
            {
                Console.WriteLine("Start making coffee...");
                nespressoMachine.CurrentState = nespressoMachine.CoffeeMakingState;
                nespressoMachine.MakeCoffee();
                nespressoMachine.CurrentState = nespressoMachine.CupState;
            }
            else if (!nespressoMachine.HandleDown)
            {
                Console.WriteLine("Cant make coffee, handle is up.");
            }
            else
            {
                Console.WriteLine("Reservoir is empty, please refill");
                nespressoMachine.CurrentState = nespressoMachine.NoWaterState;
            }
            
        }
    }
}
