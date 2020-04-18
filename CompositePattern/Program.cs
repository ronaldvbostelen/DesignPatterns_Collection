using System;
using System.Reflection.Metadata;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // var pancakeHouseMenu = new Menu("PANCAKE HOUSE MENU", "Breakfast");
            // var dinerMenu = new Menu("DINER MENU","Lunch");
            // var cafeMenu = new Menu("CAFE MENU","Dinner");
            // var dessertMenu = new Menu("DESSERT MENU","Desserts of course!");
            //
            // var composite = new Menu("ALL MENUS","All menus combined");
            //
            // composite.Add(pancakeHouseMenu);
            // composite.Add(dinerMenu);
            // composite.Add(cafeMenu);
            //
            // pancakeHouseMenu.Add(new MenuItem("Bacon Pancake","Meaty",9.55,false));
            // pancakeHouseMenu.Add(new MenuItem("Apple Pancake", "Fruity", 7.55, true));
            // dinerMenu.Add(new MenuItem("Omelette","Eggs PLS",12.5,true));
            // cafeMenu.Add(new MenuItem("T-Bone Steak","With patatoes",15.99,false));
            // cafeMenu.Add(dessertMenu);
            // dessertMenu.Add(new MenuItem("Dame Blanche","Sweet and Tasty",7.45,true));
            //
            // var waitress = new Waitress(composite);
            //
            // waitress.PrintMenu();
            // waitress.PrintVegetarianMenu();

            var compositeTest = new Menu("composite","composite menu");
            // var leaf = new MenuItem("leaf","leaf",10,true);
            var compositeNode = new Menu("Node","Node");
            compositeNode.Add(new MenuItem("Leaf","Leaf",10,true));
           compositeTest.Add(compositeNode);
           // compositeTest.Add(leaf);

            var nodeWaitress = new Waitress(compositeTest);
            nodeWaitress.PrintAllExternal();
            Console.WriteLine("\n\nINTERNAL PRINT");
            nodeWaitress.PrintMenu();
        }
    }
}
