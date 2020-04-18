using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Collections;

namespace DecoratorPattern.Condiments
{
    class Cream : BeverageDecorator
    {
        public Cream(Beverage beverage) : base(beverage)
        {
            description = beverage.GetDescription() + ", Cream";
        }

        public override decimal Cost() => (decimal) (int) beverage.GetSize()/100 * .5m + beverage.Cost();
    }
}
