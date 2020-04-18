using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.EnumeratorToIterator
{
    class EnumeratorIterator : IIterator<Car>
    {
        private IEnumerator<Car> enumerator;

        public EnumeratorIterator(IEnumerator<Car> enumerator)
        {
            this.enumerator = enumerator;
        }

        public bool HasNext() => enumerator.MoveNext();

        public Car Next() => enumerator.Current;

        public void Remove()
        {
            throw new NotImplementedException(); // do not implement
        }
    }
}
