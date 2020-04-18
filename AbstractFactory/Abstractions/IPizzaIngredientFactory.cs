using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory.Abstractions
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClam[] CreateClams();
        ISauce CreateSauce();
        IVeggie[] CreateVeggies();
        IPepperoni CreatePepperoni();
    }
}