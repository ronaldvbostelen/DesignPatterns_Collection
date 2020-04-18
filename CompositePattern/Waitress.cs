using System;
using CompositePattern.Abstractions;

namespace CompositePattern
{
    public class Waitress
    {
        private Component menus;

        public Waitress(Component menus)
        {
            this.menus = menus;
        }

        public void PrintMenu() => menus.Print();

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\nVEGETARIAN MENU\n----------------");

            foreach (var componentMenu in menus)
            {
                try
                {
                    if (componentMenu.IsVegetarian())
                    {
                        componentMenu.Print();
                    }
                }
                catch (NotImplementedException e)
                {
                }
            }

            #region Book implementation

            // using var enumerator = menus.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            //     var component = enumerator.Current;
            //     try
            //     {
            //         if (component.IsVegetarian())
            //         {
            //             component.Print();
            //         }
            //     }
            //     catch (NotImplementedException e) { }
            // }

            #endregion
        }

        public void PrintAllExternal()
        {
            Console.WriteLine("ALL EXTERNAL\n---------");
            var enumerator = menus.GetEnumerator();

            while (enumerator.MoveNext())
            {
                enumerator.Current.Print();
            }

            // foreach (var menu in menus)
            // {
            //     menu.Print();
            // try
            // {
            // if (menu.GetPrice() > 5)
            // {
            // menu.Print();
            // }
            // }
            // catch (NotImplementedException e)
            // {
            // }
            // Console.WriteLine(menu.GetDescription());
            // Console.WriteLine("-----------------");
            // }
        }
    }
}