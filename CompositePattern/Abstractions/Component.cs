using System;
using System.Collections;
using System.Collections.Generic;

namespace CompositePattern.Abstractions
{
    public abstract class Component : IEnumerable<Component>
    {
        public virtual string GetName() => throw new NotImplementedException();
        public virtual string GetDescription() => throw new NotImplementedException();
        public virtual double GetPrice() => throw new NotImplementedException();
        public virtual bool IsVegetarian() => throw new NotImplementedException();
        public virtual void Add(Component component) => throw new NotImplementedException();
        public virtual void Remove(Component component) => throw new NotImplementedException();
        public virtual Component GetChild(int index) => throw new NotImplementedException();
        public abstract void Print();
        public abstract IEnumerator<Component> GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}