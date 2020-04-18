using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.EnumeratorToIterator
{
    class CarEnumerator : IEnumerator<Car>
    {
        private IList<Car> cars;

        public CarEnumerator(IList<Car> list)
        {
            cars = list;
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public Car Current { get; }

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
