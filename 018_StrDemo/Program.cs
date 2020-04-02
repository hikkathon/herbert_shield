/*
 * Продемонстрировать применение управляющих последовательностей в строковых литералах.
 */

using System;

namespace _018_StrDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первая строка\nВторая строка\nТретья строка");
            Console.WriteLine("Один\tДва\tТри");
            Console.WriteLine("Четыри\tПять\tШесть");

            // Вставить кавычки
            Console.WriteLine("\"Зачем?\", спросил он.");

            Console.ReadKey(true);
        }
    }
}
