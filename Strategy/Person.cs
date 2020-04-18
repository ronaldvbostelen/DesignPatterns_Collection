using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Person : ITransportable
    {
        public string Name { get; }
        private IMappable from;
        private IMappable to;

        public Person(string name)
        {
            Name = name;
        }
        
        public void SetFrom(IMappable @from)
        {
            throw new NotImplementedException();
        }

        public void SetTo(IMappable to)
        {
            throw new NotImplementedException();
        }

        public override string ToString() => Name;
    }
}
