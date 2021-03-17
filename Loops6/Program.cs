/*
  Вывести число, которое является зеркальным отображением последовательности
 цифр заданного числа, например, задано число 123, вывести 321.
*/

using System;
using System.Text;

namespace Loops6
{
    internal class Program
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число, для создания его палиндрома. Корректно только для 9-ти значных чесел");
            var number = Convert.ToInt32(Console.ReadLine());
            var palindrom = 0;
            for (var n = number; n != 0; n /= 10)
            {
                palindrom = (palindrom + (n % 10)) * 10;
            }
            Console.WriteLine("Палиндром числа " + number + " : " + palindrom / 10);
        }
    }
}