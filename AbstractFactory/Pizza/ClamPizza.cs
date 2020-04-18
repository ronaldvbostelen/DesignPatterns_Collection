using System;
using AbstractFactory.Abstractions;

namespace AbstractFactory.Pizza
{
    public class ClamPizza : Abstractions.Pizza
    {
        public ClamPizza(string name, IPizzaIngredientFactory factory) : base(name, factory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this}...");
            dough = pizzaIngredientFactory.CreateDough();
            sauce = pizzaIngredientFactory.CreateSauce();
            cheese = pizzaIngredientFactory.CreateCheese();
            clams = pizzaIngredientFactory.CreateClams();
        }
    }
}