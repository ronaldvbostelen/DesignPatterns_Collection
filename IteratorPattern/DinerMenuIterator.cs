using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class DinerMenuIterator : IEnumerator<MenuItem>
    {
        private MenuItem[] items;
        private int position = -1;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool MoveNext() => ++position < items.Length;

        public void Reset() => position = -1;

        public MenuItem Current => items[position];

        object? IEnumerator.Current => Current;

        public void Dispose() => items = null;
    }
}