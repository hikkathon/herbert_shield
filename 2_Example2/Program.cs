/*
 * Эта программа демонстрирует применение переменных.
 */

using System;

namespace _2_Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x; // здесь объявляется переменная
            int y; // здесь объявляется еще одна переменная

            x = 100; // здесь переменной x присваивается значение 100

            Console.WriteLine("x содержит " + x);

            y = x / 2;

            Console.Write("y содержит x / 2: ");
            Console.WriteLine(y);

            Console.ReadKey(true);
        }
    }
}
