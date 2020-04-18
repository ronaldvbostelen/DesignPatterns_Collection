using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IteratorPattern
{
    public class DinerMenu : IEnumerable<MenuItem>
    {
        private readonly int maxItems = 6;
        private int itemIndex;
        private MenuItem[] MenuItems { get; }

        public DinerMenu()
        {
            MenuItems = new[]
            {
                new MenuItem("l", "l", false, 7.61),
                new MenuItem("k", "k", true, 7.65),
                new MenuItem("m", "m", true, 7.67),
                new MenuItem("n", "n", false, 7.68)
            };

            itemIndex = 3;
        }

        public void AddItem(MenuItem item) => MenuItems[++itemIndex] = item;

        public IEnumerator<MenuItem> GetEnumerator() => new DinerMenuIterator(MenuItems);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString() => "Diner House Menu";
    }
}