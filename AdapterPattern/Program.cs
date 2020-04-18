using System;
using System.Collections.Generic;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();

            var l = new List<IDuck>();

            l.Add(duck);
            l.Add(new TurkeyAdapter(turkey));

            foreach (var duckyDuck in l)
            {
                duckyDuck.Fly();
                
            }
        }
    }
}
