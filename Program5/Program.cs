using System;
using System.Text;

/*
Посчитать сумму элементов массива с нечетными индексами
*/

namespace Program5
{
    public class Program5
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = CreateArray();
            var sum = 0;
            for (var i = 1; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Сумма элементов массива с нечетными индексами: " + sum);
        }
        public static int[] CreateArray()
        {
            Console.WriteLine("Для теста нужно создать массив. Укажите длинну массива:");
            var length = Convert.ToInt32(Console.ReadLine());
            var random = new Random();
            if (length > 0)
            {
                var array = new int[length];
                for (var i = 0; i < length; i++)
                {
                    array[i] = random.Next(0, 10);
                }
                Console.WriteLine("Массив создан:");
                Console.Write("[");
                for (var i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i]);
                    if (i != array.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine("]");
                return array;
            }
            else
            {
                Console.WriteLine("Длинна массива может быть только больше 0. Введите число больше 0");
                return CreateArray();
            }
        }
    }
}