using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class AlternatingDinerMenuIterator : IEnumerator<MenuItem>
    {
        private MenuItem[] menuItems;
        private int position;

        public AlternatingDinerMenuIterator(MenuItem[] items)
        {
            menuItems = items;
            position = DateTime.Today.Day % 2;
        }

        public bool MoveNext() => (position += 2) < menuItems.Length;

        public void Reset()=> position = DateTime.Today.Day % 2;

        public MenuItem Current => menuItems[position];

        object? IEnumerator.Current => Current;

        public void Dispose() => menuItems = null;
    }
}