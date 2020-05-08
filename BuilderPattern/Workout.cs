namespace BuilderPattern
{
    public class Workout
    {
        public string Name { get; }

        public Workout(string name)
        {
            Name = name;
        }

        public override string ToString() => $"- {Name}";
    }
}