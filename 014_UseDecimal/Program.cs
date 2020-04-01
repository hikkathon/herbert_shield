/*
 * Использовать тип decimal для расчета скидки.
 */

using System;

namespace _014_UseDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal price;
            decimal discount;
            decimal discounted_price;

            // Расчитать цену со скидкой
            price = 19.95m;
            discount = 0.15m; // норма скидки составляет 15%

            discounted_price = price - (price * discount);

            Console.WriteLine($"Цена со скидкой: ${discounted_price}");

            Console.ReadKey(true);
        }
    }
}
