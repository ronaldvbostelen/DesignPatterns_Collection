using System;
using System.Threading;
using StatePattern.Nespresso.states;
using state = StatePattern.Nespresso.states;

namespace StatePattern.Nespresso
{
    public class NespressoMachine
    {
        private int waterAmount;
        private int cupsInBin;

        public readonly int WaterPerCup = 5;
        public readonly int MaxAmountWater = 25;
        public readonly int MaxAmountCupsInBin = 10;

        public int WaterAmount
        {
            get => waterAmount;
            set
            {
                if (value > MaxAmountWater) throw new Exception("WATER OVERFLOW");
                waterAmount = value;
            }
        }

        public int CupsInBin
        {
            get => cupsInBin;
            set
            {
                if (value > MaxAmountCupsInBin) throw new Exception("BIN IS FULL");
                cupsInBin = value;
            }
        }
        
        public bool HandleDown { get; set; }

        public state::IState CoffeeMakingState { get; }
        public state::IState CupState { get; }
        public state::IState NoCupState { get; }
        public state::IState FullBinState { get; }
        public state::IState NoWaterState { get; }

        public state::IState CurrentState { get; set; }

        public NespressoMachine(int waterAmount, int cupsInBin)
        {
            WaterAmount = waterAmount;
            CupsInBin = cupsInBin;

            CoffeeMakingState = new CoffeeMakingState(this);
            CupState = new CupState(this);
            NoCupState = new NoCupState(this);
            FullBinState = new FullBinState(this);
            NoWaterState = new NoWaterState(this);

            if (waterAmount < WaterPerCup)
            {
                CurrentState = NoWaterState;
            }
            else if (cupsInBin >= MaxAmountCupsInBin)
            {
                CurrentState = FullBinState;
            }
            else
            {
                CurrentState = NoCupState;
            }
        }

        public void InsertCup() => CurrentState.InsertCup();
        public void TurnHandle() => CurrentState.TurnHandle();
        public void PressMakeCoffeeButton() => CurrentState.PressButton();
        public void RefillWaterReservoir(int amount) => CurrentState.RefillWaterReservoir(amount);
        public void EmptyBin() => CurrentState.EmptyBin();

        public void MakeCoffee()
        {
            Console.WriteLine("Coffee starts dripping out...");
            Thread.Sleep(5000);
            WaterAmount -= WaterPerCup;
            ++CupsInBin;
            Console.WriteLine("Done.. Enjoy");
        }
    }
}
