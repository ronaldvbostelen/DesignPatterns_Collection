namespace Strategy
{
    public interface ICarrierable
    {
        int AmountOfPassengers();
        void SetRoute(IMappable from, IMappable to);
        void AddPassenger(ITransportable passenger);
        int TransportationTime(IMappable from, IMappable to);
        decimal TransportationCost();
    }
}