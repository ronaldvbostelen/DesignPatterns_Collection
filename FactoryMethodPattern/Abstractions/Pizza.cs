using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Abstractions
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings;

        protected Pizza()
        {
            toppings = new List<string>();
        }
        
        public abstract void Prepare();

        public virtual void Bake()
        {
            // 220 degrees
        }

        public virtual void Cut()
        {
            // 8 slices
        }

        public void Box()
        {
            // Put It In The Box
        }
    }
}
