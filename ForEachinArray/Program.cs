using System;

namespace ForEachinArray
{
    class Program
    {
        static void Main(string[] args)
        {//НЕ ГОДИТСЯ ДЛЯ ИЗМЕНЕНИЯ ДАННЫХ ВНУТРИ МАССИВА


            string[] fruits = { "apples", "bananas", "oranges", "pears", "plums", "pine-apple"};

            foreach(string item in fruits) //для КАЖДОГО элемента в массиве fruits items = elements
            {
                Console.WriteLine(item); //цикл будет повторятся/перебираться пока есть элементы в массиве
                if(item == "oranges")
                {
                    Console.WriteLine($"Boo, I don't like {item}");
                }
            }


        }
    }
}
