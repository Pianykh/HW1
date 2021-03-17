using System;
using System.Text;

/*
Посчитать выражение макс(а*б*с, а+б+с)+3
*/

namespace ConOp4
{
    public class Program4
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
            var sum = a + b + c;
            var product = a * b * c;
            if (sum > product)
            {
                Console.WriteLine("Сумма больше произведения. a+b+c+3 = " + (sum + 3));
            }
            else if (sum < product)
            {
                Console.WriteLine("Произведение больше суммы. a*b*c+3 = " + (product + 3));
            }
            else Console.WriteLine("Сумма и произведение равны. (a*b*c+3)=(a+b+c+3)= " + (product + 3));
        }
    }
}