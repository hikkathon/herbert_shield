/*
 * Использовать несколько операторов where.
 */

using System;
using System.Linq;

namespace _029_TwoWheres
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, -3, 0, -8, 12, 19, 6, 9, 10 };

            // Сформировать запрос на получение положительных значений меньше 10.
            var posNum = from n in nums
                         where n > 0
                         where n < 10
                         select n;

            Console.Write("Положительные значения меньше 10: ");

            // Выполнить запрос и вывести его результаты.
            foreach (int i in posNum)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
