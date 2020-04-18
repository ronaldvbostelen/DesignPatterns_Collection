using System;
using System.Collections.Generic;
using CompositePattern.Abstractions;

namespace CompositePattern
{
    public class Menu : Component
    {
        private readonly List<Component> components = new List<Component>();
        private IEnumerator<Component> enumerator;
        private string name;
        private string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override string GetName() => name;

        public override string GetDescription() => description;
        
        public override void Print()
        {
            Console.Write($"\n{GetName()}");
            Console.WriteLine($", {GetDescription()}");
            Console.WriteLine("-------------------------------------");

            foreach (var component in components)
            {
                component.Print();
            }

            #region Book way

            // using var enumerator = components.GetEnumerator();
            // while (enumerator.MoveNext())
            // {
            // enumerator.Current.Print();
            // }

            #endregion
        }

        public override IEnumerator<Component> GetEnumerator() => enumerator ??= new CompositeEnumerator(components.GetEnumerator());
        public override void Add(Component component) => components.Add(component);
        public override void Remove(Component component) => components.Remove(component);
        public override Component GetChild(int index) => components[index];
    }
}