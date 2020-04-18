using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Pizzas
{
    class NYStyledCheesePizza : Pizza
    {
        public NYStyledCheesePizza()
        {
            name = "Cheese";
            dough = "Sour";
            sauce = "Tomato";
            toppings.Add("Gouda");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
