/*
Вычислить факториал числа n. n! = 1*2*...*n-1*n;!
*/

using System;
using System.Text;

namespace Loops4
{
    public class Program4
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число для нахождения факториала. Корректно вычисляет до 12!");
            var number = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;
            if (number == 0) Console.WriteLine("О! = 0");
            else if (number > 0)
            {
                for (var i = 1; i <= number; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(number + "! = " + factorial);
            }
            else Console.WriteLine("Факториал отрицательного числа невозможен.");
        }
    }
}