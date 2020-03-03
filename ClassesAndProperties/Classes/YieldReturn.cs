using System;
using System.Collections.Generic;

namespace ClassesAndProperties.Classes
{
    public static class DynamicPolicy
    {
        public const string Rank = "Rank"; 
        public const string SecurityLevel = "SecurityLevel"; 
        public static IEnumerable<string> Get()
        {
            yield return Rank;
            yield return SecurityLevel;
        }
    }
    public static class YieldReturnDemo
    {
        public static void RunDemo()
        {
            foreach (var p in DynamicPolicy.Get())
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();
        }
    }
}
