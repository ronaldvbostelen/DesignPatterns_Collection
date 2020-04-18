using System;
using AbstractFactory.Abstractions;
using AbstractFactory.Pizza;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public NYPizzaStore()
        {
            pizzaIngredientFactory = new NYPizzaIngredientFactory();
        }

        protected override Abstractions.Pizza CreatePizza(PizzaType pizza)
        {
            switch (pizza)
            {
                case PizzaType.Cheese:
                    return new CheesePizza("NY Style Cheese Pizza", pizzaIngredientFactory);
                case PizzaType.Clam:
                    return new ClamPizza("NY Style Clam Pizza", pizzaIngredientFactory);
                default:
                    throw new ArgumentException("UNKNOWN PIZZA");
            }
        }
    }
}