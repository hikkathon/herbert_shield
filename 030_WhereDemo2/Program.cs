﻿/*
 * Продемонстрировать применение еще одного оператора where.
 */

using System;
using System.Linq;
namespace _030_WhereDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { ".com", ".net", "hsNameA.com", 
                "hsNameB.net", "test", ".network", "hsNameC.net", "hsNameD.com" };


            // Сформировать запрос на получение адресов Интернета, оканчивающихся на .net.
            var netAddrs = from addr in strs
                           where addr.Length > 4 && addr.EndsWith(".net", StringComparison.Ordinal)
                           select addr;

            // Выполнить запрос и вывести его результаты.
            foreach (var str in netAddrs)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey(true);
        }
    }
}
