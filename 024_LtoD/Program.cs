/*
 * Продемонстрировать неявное преоброзование типа long  в тип double.
 */

using System;

namespace _024_LtoD
{
    class Program
    {
        static void Main(string[] args)
        {
            long L;
            double D;

            L = 100123285L;
            D = L;

            Console.WriteLine($"L и D: {L} {D}");

            Console.ReadKey(true);
        }
    }
}
