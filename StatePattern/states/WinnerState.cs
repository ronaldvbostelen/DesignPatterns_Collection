using System;
using StatePattern.states;

namespace StatePattern
{
    public class WinnerState : GumballMachineState, IState
    {
        public WinnerState(GumBallMachine gumBallMachine) : base(gumBallMachine)
        {
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait while processing your previous purchase");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You already turned the crank");
        }

        public bool TurnCrank()
        {
            Console.WriteLine("That does not work");
            return false;
        }

        public void Dispense()
        {
            gumBallMachine.ReleaseBall();
            if (gumBallMachine.Gumballs == 0)
            {
                gumBallMachine.State = gumBallMachine.SoldOutState;
            }
            else
            {
                gumBallMachine.ReleaseBall();
                Console.WriteLine("YOU ARE A WINNER!!!");
                if (gumBallMachine.Gumballs > 0)
                {
                    gumBallMachine.State = gumBallMachine.NoQuarterState;
                }
                else
                {
                    Console.WriteLine("Oopps out of gumballs");
                    gumBallMachine.State = gumBallMachine.SoldOutState;
                }

                
            }
        }

    }
}