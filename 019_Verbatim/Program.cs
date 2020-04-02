/*
 * Продемонстрировать применение буквальных строковых литералов.
 */

using System;

namespace _019_Verbatim
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Это буквальный
строковой литерал, 
занимабщий несколько строк.");

            Console.WriteLine(@"А это вывод с табуляцией:
1   2   3   4
5   6   7   8");

            Console.WriteLine(@"Отзыв программиста: Мне нравиться ""С#"".");
            Console.ReadKey(true);
        }
    }
}
