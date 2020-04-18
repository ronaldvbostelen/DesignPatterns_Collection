using System;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Collections;
using DecoratorPattern.Condiments;
using DecoratorPattern.Misc;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Beverage darkRost = new Cream(new Cream(new Cream(new Cream(new DarkRoast(Size.VENTI)))));
            Console.WriteLine($"{darkRost.GetDescription()} {darkRost.Cost()}");

            // Beverage darkRoastTall = new DarkRoast(Size.TALL);
            // Console.WriteLine($"Cost of: {darkRoastTall.GetDescription()} {darkRoastTall.Cost()}");
            // Beverage darkRoastSmall = new DarkRoast(Size.VENTI);
            // Console.WriteLine($"Cost of: {darkRoastSmall.GetDescription()} {darkRoastSmall.Cost()}");
            //
            // Beverage darkRoast = new DarkRoast(Size.TALL);
            // Console.WriteLine($"Cost of: {darkRoast.GetDescription()} {darkRoast.Cost()}");
            // darkRoast = new Cream(darkRoast);
            // Console.WriteLine($"Cost of: {darkRoast.GetDescription()} {darkRoast.Cost()}");
            // darkRoast = new Cream(darkRoast);
            // Console.WriteLine($"Cost of: {darkRoast.GetDescription()} {darkRoast.Cost()}");
            // darkRoast = new Mocha(darkRoast);
            // Console.WriteLine($"Cost of: {darkRoast.GetDescription()} {darkRoast.Cost()}");
            // darkRoast = new Discount(10, darkRoast);
            // Console.WriteLine($"Cost of: {darkRoast.GetDescription()} {darkRoast.Cost()}");
        }
    }
}
