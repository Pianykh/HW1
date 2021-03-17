using System;
using System.Text;

/*
Проверить простое ли число? (число называется простым, если оно делится только
само на себя и на 1)
*/

namespace Loops2
{
    public class Program2
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число для проверки простое оно или составное");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Простым может быть только целое положительное число больше нуля. ");
                Console.WriteLine(number + " - не удовлетворяет эти критерии, значит не простое");
            }
            else
            {
                for (var i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("Число " + number + " - составное");
                        return;
                    }
                }
                Console.WriteLine("Число " + number + " - простое");
            }
        }
    }
}