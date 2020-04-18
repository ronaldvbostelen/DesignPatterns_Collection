using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class CafeMenu : IEnumerable<MenuItem>
    {
        public HashSet<MenuItem> MenuItems { get; }

        public CafeMenu()
        {
            MenuItems = new HashSet<MenuItem>
            {
                new MenuItem("a","b",true,5.33),
                new MenuItem("c","b",true,5.35),
                new MenuItem("d","n",true,5.36),
                new MenuItem("e","o",true,5.37),
                new MenuItem("f","p",true,5.44),
            };
        }


        public IEnumerator<MenuItem> GetEnumerator() => MenuItems.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString() => "Cafe Menu";
    }
}