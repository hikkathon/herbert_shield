/*
 * Сформировать простой запрос LINQ.
 */

using System;
using System.Linq;

namespace _028_SimpQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, -2, 3, 0, -4, 5 };

            // Сформировать простой запрос на получение только положительных значений.
            var posNums = from n in nums where n > 0  select n;

            Console.WriteLine("Положительные значения из массива nums: ");

            foreach(int i in posNums)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            // Внести изменения в массив nums.
            Console.WriteLine("\nЗадать значение 99 для элемента массива nums[1]");
            nums[1] = 99;

            Console.Write("Положительные значения из массива nums\nпосле изменений в нем: ");

            // Выполнить запрос второй раз.
            foreach(int i in posNums) 
            { 
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
