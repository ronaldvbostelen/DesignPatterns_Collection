using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class MallardDuck : IDuck
    {
        public void Quack() => Console.WriteLine("QUACK!!!");

        public void Fly() => Console.WriteLine("Im flying like a MF");
    }
}
