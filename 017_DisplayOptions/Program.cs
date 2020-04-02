/*
 * Применить команды форматирования.
 */

using System;

namespace _017_DisplayOptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("Число\tКвадрат\tКуб");

            for (i = 1; i < 10; i++)
            {
                Console.WriteLine($"{i}\t{i*i}\t{i*i*i}");
            }

            Console.WriteLine();
            Console.WriteLine("{0:###,###.##}",123456.56);

            Console.ReadKey(true);
        }
    }
}
