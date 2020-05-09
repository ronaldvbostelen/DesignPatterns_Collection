using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class FitnessScheme : IScheme
    {
        public List<Day> Days = new List<Day>();

        public IList<Day> GetScheme() => Days;

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