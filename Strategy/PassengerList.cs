using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class PassengerList
    {
        private List<ITransportable> passengers = new List<ITransportable>();
        private ICarrierable TransportStrategy;
        
        public void AddPassenger(ITransportable transportable) => passengers.Add(transportable);
        public void SetTransportStrategy(ICarrierable strategy) => TransportStrategy = strategy;

        public override string ToString() => $"Moved {passengers.Count} by {TransportStrategy}";
    }
}
