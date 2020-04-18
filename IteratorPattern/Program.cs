using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IEnumerable<MenuItem> pancakeHouseMenu = new PancakeHouseMenu();
            IEnumerable<MenuItem> dinerMenu = new DinerMenu();
            IEnumerable<MenuItem> cafeMenu = new CafeMenu();
            var waitress = new Waitress(new []{pancakeHouseMenu,dinerMenu,cafeMenu});

            waitress.PrintMenu();

        }
    }
}
