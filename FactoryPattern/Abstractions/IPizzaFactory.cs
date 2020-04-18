using SimpleFactory.Abstractions;

namespace FactoryPattern.Abstractions
{
    public interface IPizzaFactory
    {
        Pizza MakePizza(PizzaType type);
    }
}