using System;

namespace RandomFromArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apples"};

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, fruits.Length);

            Console.WriteLine($"Here are your {fruits[randomIndex]}");

        }
    }
}
