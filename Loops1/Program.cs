using System;
using System.Text;

/*
Найти сумму четных чисел и их количество в диапазоне от 1 до 99
*/

namespace Loops1
{
    public class Program1
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var count = 0;
            var sum = 0;
            for (var i = 1; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine("Сумма нечетных чисел в диапазоне 1-99: " + sum);
            Console.WriteLine("Количество нечетных чисел в диапазоне 1-99: " + count);
        }
    }
}