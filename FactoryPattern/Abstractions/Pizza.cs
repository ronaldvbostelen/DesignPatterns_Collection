using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Abstractions
{
    public abstract class Pizza
    {
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
