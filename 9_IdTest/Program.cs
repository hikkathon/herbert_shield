/*
 * Продемонстрировать применение идентификатора со знаком @.
 */

using System;

namespace _9_IdTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int @if; // применение ключевого слова if в качестве идентификатора

            for (@if = 0; @if < 10; @if++)
            {
                Console.WriteLine("@if равно " + @if);
            }

            Console.ReadKey(true);
        }
    }
}
