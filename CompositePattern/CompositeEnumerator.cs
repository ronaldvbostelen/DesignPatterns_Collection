using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CompositePattern.Abstractions;

namespace CompositePattern
{
    public class CompositeEnumerator : IEnumerator<Component>
    {
        private Stack<IEnumerator<Component>> stack = new Stack<IEnumerator<Component>>();
        
        public Component Current { get; private set; }
        
        public CompositeEnumerator(IEnumerator<Component> enumerator)
        {
            stack.Push(enumerator);
        }

        public bool MoveNext()
        {
            if (!stack.Any())
            {
                Current = null;
                return false;
            }

            var enumerator = stack.Peek();
            if (!enumerator.MoveNext())
            {
                stack.Pop();
                return MoveNext();
            }

            var component = enumerator.Current;
            stack.Push(component.GetEnumerator());
            Current = component;

            return true;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        
        object? IEnumerator.Current => Current;

        public void Dispose()
        {
            stack = null;
        }
    }
}