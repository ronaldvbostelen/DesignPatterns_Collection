using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Pizzas
{
    class NYStyledVeggiePizza : Pizza
    {
        public NYStyledVeggiePizza()
        {
            name = "Veggi";
            dough = "Sour";
            sauce = "Tomato";
            toppings.Add("Broccoli");
        }
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
