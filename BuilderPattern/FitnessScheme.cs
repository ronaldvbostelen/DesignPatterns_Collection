using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class FitnessScheme
    {
        public List<Day> Days { get; } = new List<Day>();

        public void AddDay(Day day) => Days.Add(day);
        public void RemoveDay(Day day) => Days.Remove(day);

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("[Fitness Scheme]\r\n");
            foreach (var day in Days)
            {
                sb.Append(day);
            }

            return sb.ToString();
        }

    }
}