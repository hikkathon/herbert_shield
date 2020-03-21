/*
 * Продемонстрировать применение условного оператора if.
 */

using System;

namespace _5_IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = 2;
            b = 3;

            if (a < b)
            {
                Console.WriteLine("a меньше b");
            }

            // Не подлежит выводу.
            if (a == b)
            {
                Console.WriteLine("этого никто не увидит");
            }

            Console.WriteLine();

            c = a - b; // содержит -1

            Console.WriteLine("c содержит -1");
            if (c >= 0)
            {
                Console.WriteLine("Значение с не отрицательно");
            }
            if (c < 0)
            {
                Console.WriteLine("Значение с отрицательно");
            }

            Console.WriteLine();

            c = b - a; // теперь содержит 1

            Console.WriteLine("c содержит 1");
            if (c >= 0)
            {
                Console.WriteLine("Значение с не отрицательно");
            }
            if (c < 0)
            {
                Console.WriteLine("Значение с отрицательно");
            }

            Console.ReadKey(true);
        }
    }
}
