using System;
using System.Collections.Generic;
using System.Text;
using DecoratorPattern.Collections;

namespace DecoratorPattern.Abstractions
{
    public abstract class Beverage
    {
        protected string description;
        protected Size size;

        public string GetDescription() => description;
        
        public abstract Size GetSize();
        public abstract decimal Cost();
    }
}
