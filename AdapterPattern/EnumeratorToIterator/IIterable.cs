namespace AdapterPattern.EnumeratorToIterator
{
    public interface IIterable<T>
    {
        IIterator<T> GetIterator();
    }
}