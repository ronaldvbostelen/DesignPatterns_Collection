using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Abstractions;
using SimpleFactory.Abstractions;

namespace FactoryPattern
{
    class PizzaHut : IPizzaOrder
    {
        private IPizzaFactory pizzaFactory;

        public PizzaHut()
        {
            pizzaFactory = new PizzaFactory();
        }

        public Pizza OrderPizza(PizzaType pizza)
        {
            var orderedPizza = pizzaFactory.MakePizza(pizza);

            orderedPizza.Prepare();
            orderedPizza.Bake();
            orderedPizza.Cut();
            orderedPizza.Box();

            return orderedPizza;
        }
    }
}
