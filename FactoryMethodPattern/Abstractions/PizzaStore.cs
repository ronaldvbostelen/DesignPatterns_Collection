using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Abstractions
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(PizzaType pizza)
        {
            var orderdPizza = CreatePizza(pizza);

            orderdPizza.Prepare();
            orderdPizza.Bake();
            orderdPizza.Cut();
            orderdPizza.Box();

            return orderdPizza;
        }

        protected abstract Pizza CreatePizza(PizzaType pizza);
    }
}
