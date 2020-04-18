using FactoryPattern.Abstractions;
using SimpleFactory.Abstractions;

namespace FactoryPattern
{
    public interface IPizzaOrder
    {
        Pizza OrderPizza(PizzaType pizza);
    }
}