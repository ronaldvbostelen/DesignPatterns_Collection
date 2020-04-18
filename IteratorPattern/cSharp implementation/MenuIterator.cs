using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class MenuIterator : IEnumerator<MenuItem>
    {
        private List<MenuItem> menu;
        private int position = -1;

        public MenuIterator(List<MenuItem> menu)
        {
            this.menu = menu;
        }

        public bool MoveNext() => ++position < menu.Count;

        public void Reset() => position = -1;

        public MenuItem Current => menu[position];

        object? IEnumerator.Current => Current;

        public void Dispose() => menu = null;
    }
}