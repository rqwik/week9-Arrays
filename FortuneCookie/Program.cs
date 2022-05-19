using System;

namespace FortuneCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fortune Cookie. What awaits you today?");
            string[] fortune = new string[]
            {
                "Win a Jackpot",
                "Fall in love",
                "Get a love letter",
                "Miss the bus",
                "See a unicorn in the street",
            };
            Console.WriteLine("Your cookie is: {0}", fortune.GetValue(new Random().Next(fortune.Length)));
        }
    }
}
