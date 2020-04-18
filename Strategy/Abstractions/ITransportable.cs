namespace Strategy
{
    public interface ITransportable
    {
        void SetFrom(IMappable from);
        void SetTo(IMappable to);
    }
}