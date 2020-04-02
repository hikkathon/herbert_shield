/*
 * Продемонстрировать динамическую инициализацию.
 */

using System;

namespace _020_DynInit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Длина сторон прямоугольного треугольника,
            double s1 = 4.0;
            double s2 = 5.0;

            // Инициализировать переменную hypot динамически,
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));

            Console.Write($"Гипотенуза треугольника со сторонами {s1} и {s2} равна ");

            Console.WriteLine("{0:#.###}.", hypot);

            Console.ReadKey(true);
        }
    }
}
