using System;
using System.Collections.Generic;
using CompositePattern.Abstractions;

namespace CompositePattern
{
    public class MenuItem : Component
    {
        private string name;
        private string description;
        private double price;
        private bool vegetarian;
        
        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.vegetarian = vegetarian;
        }

        public override string GetName() => name;

        public override string GetDescription() => description;

        public override double GetPrice() => price;

        public override bool IsVegetarian() => vegetarian;

        public override void Print()
        {
            Console.Write($"  {GetName()}");
            if (IsVegetarian())
            {
                Console.Write(" (v)");
            }

            Console.WriteLine($", {GetPrice()}");
            Console.WriteLine($"   -- {GetDescription()}");
        }

        public override IEnumerator<Component> GetEnumerator() => new NullEnumerator();
    }
}