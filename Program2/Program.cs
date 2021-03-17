using System;
using System.Text;

/*
Найти максимальный элемент массива
*/

namespace Program2
{
    public class Program2
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = СreateArray();
            var max = array[0];
            foreach (var i in array)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Максимальное число в массиве: " + max);
        }
        public static int[] СreateArray()
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
                return СreateArray();
            }
        }
    }
}