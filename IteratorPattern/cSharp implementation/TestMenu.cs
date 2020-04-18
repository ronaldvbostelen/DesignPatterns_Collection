using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class TestMenu : IEnumerable<MenuItem>
    {
        private List<MenuItem> menuItems;

        public TestMenu()
        {
            menuItems = new List<MenuItem>
            {
                new MenuItem("a","e",false,9.51),
                new MenuItem("b","f",true,9.52),
                new MenuItem("c","g",false,9.53),
                new MenuItem("d","h",true,9.54)
            };
        }

        public IEnumerator<MenuItem> GetEnumerator() => new MenuIterator(menuItems);

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}