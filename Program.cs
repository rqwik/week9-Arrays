using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fruits = {"apples", "bananas", "oranges", "pears", "plums"}; []- массив с данными типа-стринг с несколькими строками
            string[] fruits = new string[5]; //пустой массив, готовый для принятия данных - 5 количество элементов
            fruits[0] = "apples";
            fruits[1] = "bananas";
            fruits[2] = "oranges";
            fruits[3] = "pears";
            fruits[4] = "plums";

            Console.WriteLine(fruits[2]);

            fruits[3] = "tangerines"; //arrays are mutable
            Console.WriteLine(fruits[2]);

        }
    }
}
