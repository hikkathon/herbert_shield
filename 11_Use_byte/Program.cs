/*
 * Использовать тип byte.
 */

using System;

namespace _11_Use_byte
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x;
            int sum;

            sum = 0;

            for (x = 1; x <= 100; x++)
            {
                sum += x;
            }
            Console.WriteLine("Сумма чисел от 1 до 100 равна " + sum);

            Console.ReadKey(true);
        }
    }
}
