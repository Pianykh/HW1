using System;
using System.Text;

/*
Найти минимальный элемент массива
*/

namespace Program1
{
    internal class Program
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = СreateArray();
            var min = array[0];
            foreach (var i in array)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            Console.WriteLine("Минимальное число в массиве: " + min);
        }

        public static int[] СreateArray()
        {                                                //Это метод для создания массива заданной длинны
            Console.WriteLine("Для теста нужно создать массив. Укажите длинну массива:"); //Он есть в каждом задании этого блока
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