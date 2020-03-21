/*
 * Продемонстрировать применение оператора цикла for.
 */

using System;

namespace _6_ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for(count = 0; count < 5; count++)
            {
                Console.WriteLine("Это подсчет: " + count);
            }

            Console.WriteLine("Готово!");

            Console.ReadKey(true);
        }
    }
}
