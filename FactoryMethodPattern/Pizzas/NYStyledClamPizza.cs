using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.Abstractions;

namespace FactoryMethodPattern.Pizzas
{
    class NYStyledClamPizza : Pizza
    {
        public NYStyledClamPizza()
        {
            name = "Clam";
            dough = "Sour";
            sauce = "Tomato";
            toppings.Add("Mossel");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
