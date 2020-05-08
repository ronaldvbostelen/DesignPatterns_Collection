using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var coach = new Coach();

            coach.MakeFitnessScheme();
            var scheme = coach.FitnessScheme;

            Console.WriteLine(scheme);
        }
    }
}
