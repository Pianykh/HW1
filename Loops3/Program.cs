using System;
using System.Text;

/*Найти корень натурального числа с точностью до целого (рассмотреть вариант
  последовательного подбора и метод бинарного поиска)*/

namespace Loops3
{
    public class Program3
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите цифровое обозначение метода для нахождения корня.");
            Console.WriteLine("1 - перебор. 2 - бинарный поиск.");
            var method = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число для нахождения его корня.");
            var number = Convert.ToInt32(Console.ReadLine());
            if (method == 1)
            {
                Console.WriteLine(FindSqrtBruteForce(number));
            }
            else if (method == 2)
            {
                Console.WriteLine(FindSqrtBinarySearch(number)); ;
            }
        }
        public static int FindSqrtBruteForce(int number)
        {
            var sqrt = 0;
            for (var i = 1; i * i <= number; i++)
            {
                sqrt = i;
            }
            if (((sqrt + 1) * (sqrt + 1) - number) <= (number - sqrt * sqrt))
            {  // Определение в какую сторону округлять результат
                return sqrt + 1;                                          // путем нахождения разниц между числом и
            }                                                           // двумя ближними корнями и сравнении этих разниц
            else return sqrt;
        }
        public static int FindSqrtBinarySearch(int number)
        {
            var sqrt = number;
            while (sqrt * sqrt > number)
            {
                sqrt /= 2;
            }
            while (sqrt * sqrt < number)
            {
                sqrt++;
            }
            if (((sqrt) * (sqrt) - number) <= (number - (sqrt - 1) * (sqrt - 1)))
            {  // Определение в какую сторону округлять результат
                return sqrt;                                                // путем нахождения разниц между числом и
            }                                                               // двумя ближними корнями и сравнении этих разниц
            else return sqrt - 1;
        }
    }
}