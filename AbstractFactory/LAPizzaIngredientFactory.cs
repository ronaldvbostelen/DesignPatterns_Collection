using AbstractFactory.Abstractions;
using AbstractFactory.Ingredients;
using AbstractFactory.Ingredients.Abstractions;

namespace AbstractFactory
{
    public class LAPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() => new ThickCrustDough();

        public ICheese CreateCheese() => new ReggianoCheese();

        public IClam[] CreateClams() => new IClam[] {new Mussel(), new Mussel()};

        public ISauce CreateSauce() => new TomatoSauce();

        public IVeggie[] CreateVeggies() => new IVeggie[]{new Onion(), new RedPepper(), };

        public IPepperoni CreatePepperoni() => new Salsiccia();
    }
}