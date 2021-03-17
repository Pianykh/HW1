using System;
using System.Text;

/*
Найти суммы только положительных из трех чисел
*/

namespace ConOp3
{
    public class Program3
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите первое число");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            var c = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            if (a >= 0)
            {
                sum += a;
            }
            if (b >= 0)
            {
                sum += b;
            }
            if (c >= 0)
            {
                sum += c;
            }
            Console.WriteLine("Сумма только положительных чисел: " + sum);
        }
    }
}