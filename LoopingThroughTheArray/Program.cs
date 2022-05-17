using System;

namespace LoopingThroughTheArray
{
    class Program
    {
        static void Main(string[] args)
        {// МОЖНО ПЕРЕПИСАТЬ/ИЗМЕНИТЬ ДАННЫЕ ВНУТРИ МАССИВА


            string[] fruits = {"apples", "bananas", "oranges", "pears", "plums", "pine-apple"};
            //fruits.Lenght - длинна массива
            //the index of the last element = array.Lenght - 1

            //fruits[6] = "kiwi";   - эта строка не будет работать - она за пределами массива (если хочу добавить данные - то только в массив)
            for(int i =0; i < fruits.Length; i ++)
            {
                Console.WriteLine(fruits[i]);
                //заменить oranges на tangerines, не зная индекса апельчинов
            }

            Console.WriteLine();

            for (int i = 0; i < fruits.Length; i++)
            {
                if(fruits[i] == "oranges")
                {
                    fruits[i] = "tangerines";
                }
            }
            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);
            }


        }
    }
}
