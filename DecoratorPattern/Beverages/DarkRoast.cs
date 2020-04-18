using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Abstractions;
using DecoratorPattern.Collections;

namespace DecoratorPattern
{
    class DarkRoast : Beverage
    {
        public DarkRoast(Size size)
        {
            this.size = size;
            description = $"({size.ToString()}) DarkRoast";
        }

        public override Size GetSize() => size;

        public override decimal Cost() => (decimal) (int) size/100 * 1.5m;
    }
}
