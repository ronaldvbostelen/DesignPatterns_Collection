using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern.EnumeratorToIterator
{
    class EnumeratorIterator<T> : IIterator<T>
    {
        private IEnumerator<T> enumerator;

        public EnumeratorIterator(IEnumerator<T> enumerator)
        {
            this.enumerator = enumerator;
        }

        public bool HasNext() => enumerator.MoveNext();

        public T Next() => enumerator.Current;

        public void Remove()
        {
            throw new NotImplementedException(); // do not implement
        }
    }
}
