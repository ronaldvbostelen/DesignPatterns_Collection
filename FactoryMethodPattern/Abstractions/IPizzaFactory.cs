namespace FactoryMethodPattern.Abstractions
{
    public interface IPizzaFactory
    {
        Pizza MakePizza(PizzaType pizza);
    }
}