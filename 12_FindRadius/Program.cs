/*
 * Определить радиус окружности по площади круга.
 */

using System;

namespace _12_FindRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            double area;

            area = 10.0;

            r = Math.Sqrt(area / 3.1416);

            Console.WriteLine("Радиус равен " + r);

            Console.ReadKey(true);
        }
    }
}
