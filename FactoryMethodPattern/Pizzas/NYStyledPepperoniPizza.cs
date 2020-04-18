using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Pizzas
{
    class NYStyledPepperoniPizza : Pizza
    {
        public NYStyledPepperoniPizza()
        {
            name = "Pepperoni";
            dough = "Sour";
            sauce = "Tomato";
            toppings.Add("Pepperoni");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
