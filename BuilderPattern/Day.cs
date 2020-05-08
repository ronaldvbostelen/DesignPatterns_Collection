using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Day
    {
        private string Name;
        public List<Workout> Workouts { get; } = new List<Workout>();

        public Day(string name)
        {
            Name = name;
        }
        
        public void AddWorkout(Workout workout) => Workouts.Add(workout);
        public void RemoveWorkout(Workout workout) => Workouts.Remove(workout);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append($"Day: {Name}\r\nExercises:\r\n");

            foreach (var workout in Workouts)
            {
                sb.Append($"{workout}\r\n");
            }

            return sb.ToString();
        }
    }
}
