using System;
using System.Collections.Generic;

namespace IteratorPattern
{
    public class Waitress
    {
        private IEnumerable<IEnumerable<MenuItem>> menus;

        public Waitress(IEnumerable<IEnumerable<MenuItem>> menus)
        {
            this.menus = menus;
        }

        public void PrintMenu()
        {
            using var enumerator = menus.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                PrintMenu(enumerator.Current.GetEnumerator());
            }
        }

        private void PrintMenu(IEnumerator<MenuItem> menu)
        {
            while (menu.MoveNext())
            {
                Console.WriteLine(menu.Current);
            }
        }
    }
}