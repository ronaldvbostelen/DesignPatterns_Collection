using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Collections;

namespace DecoratorPattern.Abstractions
{
    public abstract class BeverageDecorator : Beverage
    {
        protected Beverage beverage;

        protected BeverageDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override Size GetSize() => beverage.GetSize();
    }
}
