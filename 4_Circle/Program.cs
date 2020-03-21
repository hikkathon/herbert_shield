/*
 * Вычислить площадь
 */

using System;

namespace _4_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;

            radius = 10.0;
            area = radius * radius * 3.1416;

            Console.WriteLine("Площадь равна: " + area);

            Console.ReadKey(true);
        }
    }
}
