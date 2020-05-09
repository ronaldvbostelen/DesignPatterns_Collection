using System;
using System.Collections.Generic;
using ProxyPattern.ProtectionProxy;

namespace ProtectionProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var alice = new PersonBean
            {
                Name = "Alice",
                Gender = "Female",
                HotOrNotRating = 0,
                Interests = new List<string> { "Traveling" }
            };

            var ownerProxy = new PersonBeanProxy(alice, true);
            var nonOwnerProxy = new PersonBeanProxy(alice, false);

            ownerProxy.Interests.Add("Reading");
            Console.WriteLine("Interests");
            foreach (var ownerProxyInterest in ownerProxy.Interests)
            {
                Console.WriteLine("\t -" + ownerProxyInterest);
            }

            nonOwnerProxy.Interests.Add("Farting"); // Get FackeD

            ownerProxy.Interests.Add("Partying");

            Console.WriteLine("Interests");
            foreach (var ownerProxyInterest in ownerProxy.Interests)
            {
                Console.WriteLine("\t -" + ownerProxyInterest);
            }

        }
    }
}
