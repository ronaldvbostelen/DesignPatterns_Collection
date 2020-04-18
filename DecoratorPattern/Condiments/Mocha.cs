using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Collections;

namespace DecoratorPattern.Condiments
{
    class Mocha : BeverageDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
            description = beverage.GetDescription() + ", Mocha";
        }

        public override decimal Cost() => (decimal) (int) beverage.GetSize() /100 * .65m + beverage.Cost();
    }
}
