/*
 * Пример неожиданного результата продвижения типов!
 */

using System;

namespace _026_PromDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b;
            b = 10;
            b = (byte)(b * b); // Необходимо приведение типов!!
            Console.WriteLine($"b: {b}");

            Console.ReadKey(true);
        }
    }
}
