using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.EnumeratorToIterator
{
    class CarCatlog : IEnumerable<Car>
    {
        public List<Car> CarModels { get; set; }

        public IEnumerator<Car> GetEnumerator() => new CarEnumerator(CarModels);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IIterator<Car> GetIterator() => new EnumeratorIterator(new CarEnumerator(CarModels));
    }
}
