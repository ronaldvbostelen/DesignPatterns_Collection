using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CityBus : ICarrierable
    {
        private List<ITransportable> passengers = new List<ITransportable>();
        public int AmountOfPassengers() => 25;
        public void SetRoute(IMappable @from, IMappable to)
        {
            throw new NotImplementedException();
        }

        public void AddPassenger(ITransportable passenger) => passengers.Add(passenger);
        public int TransportationTime(IMappable @from, IMappable to) => 125;
        public decimal TransportationCost() => 5.25m;

        public override string ToString() => "Citybus";
    }
}
