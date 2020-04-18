using System;
using AbstractFactory.Abstractions;

namespace AbstractFactory.Pizza
{
    public class CheesePizza : Abstractions.Pizza
    {
        public CheesePizza(string name, IPizzaIngredientFactory factory) : base(name, factory)
        {
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {this}");
            dough = pizzaIngredientFactory.CreateDough();
            sauce = pizzaIngredientFactory.CreateSauce();
            cheese = pizzaIngredientFactory.CreateCheese();
        }

        
    }
}