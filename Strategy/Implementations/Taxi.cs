using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementations
{
    class Taxi : ICarrierable
    {
        private List<ITransportable> passengers = new List<ITransportable>();

        public int AmountOfPassengers() => 3;
        public void SetRoute(IMappable @from, IMappable to)
        {
            throw new NotImplementedException();
        }

        public void AddPassenger(ITransportable passenger) => passengers.Add(passenger);
        public int TransportationTime(IMappable @from, IMappable to) => 44;
        public decimal TransportationCost() => 99.20m;

        public override string ToString() => "Taxi";
    }
}
