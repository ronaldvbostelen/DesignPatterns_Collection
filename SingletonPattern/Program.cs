using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var prefs = UserPreference.GetInstance();

            Console.WriteLine(prefs.SayWhat);


        }
    }
}
