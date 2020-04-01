/*
 * Продемонстрировать применение кодового блока.
 */

using System;

namespace _7_BlockDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, d;

            i = 5;
            j = 10;

            // Адресатом этого оператора if служит кодовый блок.
            if (1 != 0)
            {
                Console.WriteLine("i не равно нулю");
                d = j / i;
                Console.WriteLine("j / i равно " + d);
            }

            Console.ReadKey(true);
        }
    }
}
