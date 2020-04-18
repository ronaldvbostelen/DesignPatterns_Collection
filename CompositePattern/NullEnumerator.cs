using System.Collections;
using System.Collections.Generic;
using CompositePattern.Abstractions;

namespace CompositePattern
{
    public class NullEnumerator : IEnumerator<Component>
    {
        public bool MoveNext() => false;

        public void Reset()
        {
            throw new System.NotImplementedException();
        }

        public Component Current => null;

        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            //
        }
    }
}