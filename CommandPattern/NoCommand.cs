namespace CommandPattern
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            //
        }

        public void Undo()
        {
            //
        }

        public bool CanExecute() => false;
    }
}