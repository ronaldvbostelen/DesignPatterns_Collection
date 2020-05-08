using System;
using StatePattern.Nespresso;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            var gumballmachine = new GumBallMachine(25);
            Console.WriteLine(gumballmachine.GetState());
            gumballmachine.InsertQuarter();
            Console.WriteLine(gumballmachine.GetState());
            gumballmachine.TurnCrank();
            Console.WriteLine(gumballmachine.GetState());
            //
            // var nespresso = new NespressoMachine(25, 0);
            // for (int i = 0; i < 25; i++)
            // {
            //     nespresso.TurnHandle();
            //     nespresso.InsertCup();
            //     nespresso.TurnHandle();
            //     nespresso.PressMakeCoffeeButton();
            // }
            //
            // nespresso.RefillWaterReservoir(25);
            // nespresso.PressMakeCoffeeButton();

            // nespresso.InsertCup();
            // nespresso.PressMakeCoffeeButton();
            // Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
            // nespresso.TurnHandle();
            // nespresso.TurnHandle();
            // Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
            // nespresso.InsertCup();
            // nespresso.TurnHandle();

            // nespresso.TurnHandle();
            // Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
        }
    }
}
