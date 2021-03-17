/*
Посчитать сумму цифр заданного числа
*/

using System;
using System.Text;

namespace Loops5
{
    public class Program5
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число, для подсчета суммы его цифр");
            var number = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (var n = number; n != 0; n /= 10)
            {
                sum += (n % 10);
            }
            Console.WriteLine("Сумма цифр числа " + number + " равна: " + sum);
        }
    }
}