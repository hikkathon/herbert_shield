/*
 * Вычислить сумму и произведене чисел от 1 до 10.
 */

using System;

namespace _8_ProdSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int prod;
            int sum;
            int i;

            sum = 0;
            prod = 1;

            for (i = 1; i <= 10; i++)
            {
                sum += i;
                prod *= i;
            }

            Console.WriteLine("Сумма равна " + sum);
            Console.WriteLine("Произведение равно " + prod);

            Console.ReadKey(true);
        }
    }
}
