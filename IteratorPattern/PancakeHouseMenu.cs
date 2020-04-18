using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class PancakeHouseMenu : IEnumerable<MenuItem>
    {
        public List<MenuItem> MenuItems { get; }

        public PancakeHouseMenu()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem("a","h",false,5.52),
                new MenuItem("b","i",false,5.53),
                new MenuItem("c","j",false,5.54),
                new MenuItem("d","k",false,5.55),
                new MenuItem("e","l",false,5.56),
                new MenuItem("f","m",false,5.57),
                new MenuItem("g","n",false,5.58),
            };
        }

        public IEnumerator<MenuItem> GetEnumerator() => MenuItems.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString() => "Pancake House Menu";
    }
}