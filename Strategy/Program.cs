using System;
using Strategy.Implementations;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var passengers = new PassengerList();
            
            passengers.AddPassenger(new Person("Kees"));
            passengers.AddPassenger(new Person("Henk"));
            passengers.AddPassenger(new Person("Anne"));
            passengers.AddPassenger(new Person("Olga"));

            passengers.SetTransportStrategy(new Car());
            Console.WriteLine(passengers);
            passengers.SetTransportStrategy(new CityBus());
            Console.WriteLine(passengers);
            passengers.SetTransportStrategy(new Taxi());
            Console.WriteLine(passengers);
        }
    }
}
