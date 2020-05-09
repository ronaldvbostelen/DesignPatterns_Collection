using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.EnumeratorToIterator
{
    class CarCatlog : IIterable<Car>
    {
        public IList<Car> CarModels { get; set; }
        
        public IIterator<Car> GetIterator() => new EnumeratorIterator<Car>(CarModels.GetEnumerator());
    }
}
