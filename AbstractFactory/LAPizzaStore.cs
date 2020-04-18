using System;
using AbstractFactory.Abstractions;
using AbstractFactory.Pizza;

namespace AbstractFactory
{
    public class LAPizzaStore : PizzaStore
    {
        private IPizzaIngredientFactory pizzaIngredientFactory;

        public LAPizzaStore()
        {
            pizzaIngredientFactory = new LAPizzaIngredientFactory();
        }

        protected override Abstractions.Pizza CreatePizza(PizzaType pizza)
        {
            switch (pizza)
            {
                case PizzaType.Cheese:
                    return new CheesePizza("LA Style Cheese Pizza", pizzaIngredientFactory);
                case PizzaType.Clam:
                    return new ClamPizza("LA Style Clam Pizza", pizzaIngredientFactory);
                default:
                    throw new ArgumentException("UNKNOWN PIZZA");
            }
        }
    }
}