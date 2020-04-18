using System;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Abstractions
{
    public abstract class Pizza
    {
        protected string name;
        protected IPizzaIngredientFactory pizzaIngredientFactory;
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggie[] veggies;
        protected ICheese cheese;
        protected IPepperoni pepperoni;
        protected IClam[] clams;
        
        protected Pizza(string name, IPizzaIngredientFactory factory)
        {
            pizzaIngredientFactory = factory;
            this.name = name;
        }
        
        public abstract void Prepare();

        public virtual void Bake() => Console.WriteLine($"BAKED at 200 degrees");

        public void Cut()
        {
            //Cut
        }

        public void Box()
        {
            // Boxed
        }

        public override string ToString() => name;
    }
}