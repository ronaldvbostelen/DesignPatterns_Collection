using System;

namespace AdapterPattern.EnumeratorToIterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Next();
        void Remove();
    }
}