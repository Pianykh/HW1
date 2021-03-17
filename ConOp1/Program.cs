using System;
using System.Text;

/*
Если а – четное посчитать а*б, иначе а+б
*/

namespace ConOp1
{
    public class Program1
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите первое число");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("Число а - четное. Произведение двух чисел: " + (a * b));
            }
            else
            {
                Console.WriteLine("Число а - нечетное. Сумма двух чисел: " + (a + b));
            }
        }
    }
}