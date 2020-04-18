using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Abstractions;
using SimpleFactory.Abstractions;

namespace FactoryPattern
{
    class CheesePizza : Pizza
    {
        public override void Bake()
        {
            //200 degrees
        }

        public override void Prepare()
        {
            // CHEESE
        }
    }
}
