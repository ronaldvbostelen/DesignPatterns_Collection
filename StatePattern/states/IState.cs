namespace StatePattern
{
    public interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        bool TurnCrank();
        void Dispense();
    }
}