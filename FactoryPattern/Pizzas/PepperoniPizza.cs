using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Abstractions;
using SimpleFactory.Abstractions;

namespace FactoryPattern
{
    class PepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            // HOT MEAT
        }
    }
}
