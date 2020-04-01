/*
 * Применить тип decimalдля расчета будующей стоимости капиталовложений.
 */

using System;

namespace _015_FutVal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amount;
            decimal rate_of_return;
            int years, i;

            amount = 1000.0M;
            rate_of_return = 0.07M;
            years = 10;

            Console.WriteLine($"Первоночальное вложение: ${amount}");
            Console.WriteLine($"Норма прибыли: ${rate_of_return}");
            Console.WriteLine($"В течении {years} лет");

            for (i = 0; i < years; i++)
            {
                amount = amount + (amount * rate_of_return);
            }

            Console.WriteLine($"Будующая стоимость равна ${amount}");

            Console.ReadKey(true);
        }
    }
}
