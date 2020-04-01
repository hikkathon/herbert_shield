/*
 * Продимонстрировать применение типа bool.
 */

using System;

namespace _016_BoolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = false;

            Console.WriteLine($"b равно {b}");
            b = true;
            Console.WriteLine($"b равно {b}");

            // Логическое значение может управлять оператором if.
            if (b)
            {
                Console.WriteLine("Выполняется!");
            }
            b = false;
            if (b)
            {
                Console.WriteLine("Не выполняется!");
            }

            // Результат выполнения оператора отношения является логическое значение.
            Console.WriteLine($"10 > 9 равно {10 > 9}");

            Console.ReadKey(true);
        }
    }
}
