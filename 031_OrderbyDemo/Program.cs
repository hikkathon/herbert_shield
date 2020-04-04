/*
 * Продемонстрировать применение оператора orderby.
 */

using System;
using System.Linq;

namespace _031_OrderbyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, -19, 4, 7, 2, -5, 0 };

            // Сформировать запрос на получение значений в отсортированном порядке.
            var posNum = from n in nums
                         orderby n ascending
                         select n;

            Console.Write("Значения по нарастающей: ");

            // Выполнить запроси вывести его результаты.
            foreach(int i in posNum)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
