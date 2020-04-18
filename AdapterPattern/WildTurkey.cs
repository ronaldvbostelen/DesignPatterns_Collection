using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class WildTurkey : ITurkey
    {
        public void Gobble() => Console.WriteLine("Gobble gobble");

        public void Fly() => Console.WriteLine("Floppy fly");
    }
}
