using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var chat = new ChatRoom(); // PUSH

            var u1 = new User("Kees",chat);
            var u2 = new User("Sanne", chat);

            u1.SendMessage("Hoi Sanne");
            u2.SendMessage("Hoi Kees");
        }
    }
}
