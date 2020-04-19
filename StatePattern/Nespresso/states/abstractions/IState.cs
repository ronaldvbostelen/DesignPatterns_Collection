namespace StatePattern.Nespresso.states
{
    public interface IState
    {
        void TurnHandle();
        void RefillWaterReservoir(int amount);
        void InsertCup();
        void PressButton();
        void EmptyBin();
    }
}