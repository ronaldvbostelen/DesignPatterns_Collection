using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementations
{
    class Car : ICarrierable
    {
        private List<ITransportable> passengers = new List<ITransportable>();
        public int AmountOfPassengers() => 4;
        public void SetRoute(IMappable @from, IMappable to)
        {
            throw new NotImplementedException();
        }

        public void AddPassenger(ITransportable passenger) => passengers.Add(passenger);

        public int TransportationTime(IMappable @from, IMappable to) => 34;

        public decimal TransportationCost() => 15.87m;


        public override string ToString() => "Car";
    }
}
