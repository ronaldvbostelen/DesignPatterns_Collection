using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public class GumBallMachine
    {
        public IState State { get; set; }
        public int Gumballs { get; private set; }
        public IState SoldOutState { get; }
        public IState NoQuarterState { get; }
        public IState HasQuarterState { get; }
        public IState SoldState { get; }
        public IState WinnerState { get; }

        public GumBallMachine(int gumballs)
        {
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);

            Gumballs = gumballs;
            State = gumballs > 0 ? NoQuarterState : SoldOutState;
        }

        public void InsertQuarter() => State.InsertQuarter();
        public void EjectQuarter() => State.EjectQuarter();

        public void TurnCrank()
        {
            if (State.TurnCrank())
            {
                State.Dispense();
            }
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot..");
            if (Gumballs > 0) --Gumballs;
        }
    }
}
