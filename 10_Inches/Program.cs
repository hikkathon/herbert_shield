/*
 * Вычислить расстояние от земли до солнца в дюймах.
 */

using System;

namespace _10_Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            long inches;
            long miles;

            miles = 93000000; // 93 000 000 миль до солнца

            // 5 280 футов в миле, 12 дюймов в футе,
            inches = miles * 5280 * 12;

            Console.WriteLine("Расстояние до Солнца: " + inches + " дюймов.");

            Console.ReadKey(true);
        }
    }
}
