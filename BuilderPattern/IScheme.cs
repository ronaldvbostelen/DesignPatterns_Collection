using System.Collections.Generic;

namespace BuilderPattern
{
    public interface IScheme
    {
        IList<Day> GetScheme();
        void AddDay(Day day);
        void RemoveDay(Day day);
    }
}