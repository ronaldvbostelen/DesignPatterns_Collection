using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Abstractions;
using SimpleFactory.Abstractions;

namespace FactoryPattern
{
    class PizzaFactory : IPizzaFactory
    {
        public Pizza MakePizza(PizzaType type)
        {
            switch (type)
            {
                case PizzaType.Cheese:
                    return new CheesePizza();
                case PizzaType.Clam:
                    return new ClamPizza();
                case PizzaType.Pepperoni:
                    return new PepperoniPizza();
                case PizzaType.Veggie:
                    return new VeggiePizza();
                default:
                    throw new ArgumentOutOfRangeException("UNKNOWN TYPE");
            }
        }
    }
}
