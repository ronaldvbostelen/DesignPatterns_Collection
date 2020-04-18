using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Collections;

namespace DecoratorPattern.Misc
{
    class Discount : BeverageDecorator
    {
        private readonly double discount;

        public Discount(int discount, Beverage beverage) : base(beverage)
        {
            this.discount = (double) (100 - discount) / 100;
            description = beverage.GetDescription() + " [discount]";
        }

        public override Size GetSize() => beverage.GetSize();

        public override decimal Cost() => Math.Round((decimal)discount * beverage.Cost(),2);
    }
}
