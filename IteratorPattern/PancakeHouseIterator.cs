using System.Collections.Generic;

namespace IteratorPattern
{
    public class PancakeHouseIterator : IIterator<MenuItem>
    {
        private List<MenuItem> menuItems;
        private int position;

        public PancakeHouseIterator(List<MenuItem> menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext() => position < menuItems.Count;

        public MenuItem Next() => menuItems[position++];
    }
}