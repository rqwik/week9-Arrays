﻿using System;

namespace MatterOfTaste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Matter of taste)");
            Console.Write("Hi, please enter your favorite color: ");

            string[] colors = new string[]
            {
                "red",
                "blue",
                "green"
            };
            string userColor = Console.ReadLine().ToLower();

            if (Array.Exists(colors, color => color.Equals(userColor)))
            {
                Console.WriteLine("We are perfect together.");
            }
            else
            {
                Console.WriteLine("Every man to his taste.");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(); // OR OTHER VARIANT

            Console.WriteLine("Matter of taste)");
            Console.Write("Hi, please enter your favorite color: ");
            string[] color = { "red", "blue", "green" };
            string userChoice = Console.ReadLine().ToLower();

            if (Array.Exists(color, color => color.Equals(userChoice)))
            {
                Console.WriteLine("We are perfect together.");
            }
            else
            {
                Console.WriteLine("Every man to his taste.");
            }

        }
    }
}
