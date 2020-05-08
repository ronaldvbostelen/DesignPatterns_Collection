using StatePattern;

namespace ProxyPattern
{
    public class UpgradedGumballMachine : GumBallMachine
    {
        public string Location { get; }

        public UpgradedGumballMachine(int gumballs, string location) : base(gumballs)
        {
            Location = location;
        }
    }
}