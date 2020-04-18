using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using FactoryMethodPattern.Abstractions;
using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizza)
        {
            switch (pizza)
            {
                case PizzaType.Pepperoni:
                    return  new NYStyledPepperoniPizza();
                case PizzaType.Clam:
                    return new NYStyledClamPizza();
                case PizzaType.Veggie:
                    return new NYStyledVeggiePizza();
                case PizzaType.Cheese:
                    return new NYStyledCheesePizza();
                default:
                    throw new InvalidEnumArgumentException("UNKNOWN PIZZA");
            }
        }
    }
}
