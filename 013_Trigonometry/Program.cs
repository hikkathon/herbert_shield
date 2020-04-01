/*
 * Продемонстрировать   приминение тригономеьрических функций.
 */

using System;

namespace _013_Trigonometry
{
    class Program
    {
        static void Main(string[] args)
        {
            double theta; // угол в радианах

            for (theta=0.1; theta <= 0.1; theta += 0.1 )
            {
                Console.WriteLine("Синус угла " + theta + " равен " + Math.Sin(theta));
                Console.WriteLine("Косинус угла " + theta + " равен " + Math.Cos(theta));
                Console.WriteLine("Тангенс угла " + theta + " равен " + Math.Tan(theta));
                Console.WriteLine();
            }

            Console.ReadKey(true);
        }
    }
}
