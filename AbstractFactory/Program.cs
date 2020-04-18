using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var NYstore = new NYPizzaStore();
            var LAstore = new LAPizzaStore();

            NYstore.OrderPizza(PizzaType.Clam);
            LAstore.OrderPizza(PizzaType.Clam);
        }
    }
}
