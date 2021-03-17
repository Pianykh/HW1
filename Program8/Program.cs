using System;
using System.Text;

/*Поменять местами первую и вторую половину массива,
    например, для массива 1 2 3 4, результат 3 4 1 2
*/
/*
ПОЯСНЕНИЕ К РЕШЕНИЮ: В задании явно не указано как поступать с массивами в которых кол-во элементов нечетное.
Можно делить не совсем пополам, округляя количество элементов в большую сторону в какой-либо из частей.
Но это противоречит заданию, так как написано "половины". Поэтому мое решение в случае с нечетным массивом оставляет
центральный элемент массива на своем месте, а возникшие половины меняет местами, не создавая новый массив.
*/

namespace Program8
{
    public class Program8
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = CreateArray();
            var afterHalfPointer = array.Length / 2 + array.Length % 2;
            for (var startPointer = 0; startPointer < (array.Length / 2);
                startPointer++, afterHalfPointer++)
            {
                array[afterHalfPointer] = array[afterHalfPointer] ^ array[startPointer];
                array[startPointer] = array[afterHalfPointer] ^ array[startPointer];
                array[afterHalfPointer] = array[afterHalfPointer] ^ array[startPointer];
            }
            Console.WriteLine("Первая и левая половины массива заменены местами: ");
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