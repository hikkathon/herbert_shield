/*
 * Продемонстрировать время существования переменной.
 */

using System;

namespace _023_VarInitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;

            for(x=0; x < 3; x++)
            {
                int y = -1; // Переменная y инициализируется при каждом входе в блок.
                Console.WriteLine($"y равно: {y}");

                y = 100;
                Console.WriteLine($"y теперь равно: {y}");
            }

            Console.ReadKey(true);
        }
    }
}
