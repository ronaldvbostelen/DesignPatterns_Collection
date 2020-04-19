using System;
using StatePattern.Nespresso;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // var gumballmachine = new GumBallMachine(25);


            // gumballmachine.InsertQuarter();
            // gumballmachine.TurnCrank();


            var nespresso = new NespressoMachine(25, 0);
            nespresso.InsertCup();
            nespresso.PressMakeCoffeeButton();
            Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
            nespresso.TurnHandle();
            nespresso.TurnHandle();
            Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
            nespresso.InsertCup();
            nespresso.TurnHandle();
            
            nespresso.TurnHandle();
            Console.WriteLine($"cups in bin {nespresso.CupsInBin}");
        }
    }
}
