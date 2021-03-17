using System;
using System.Text;

/*
Найти индекс минимального элемента массива
*/
/*
ПОЯСНЕНИЕ К РЕШЕНИЮ: В условии не сказано какой индекс указывать как индекс минимального элемента,
в том случае, если минимальных элементов несколько. Поэтому данное решение предполагает вывод нескольких
индексов через запятую для таких случаев
*/

namespace Program3
{
    public class Program3
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = СreateArray();
            var result = "";
            var indexOfMin = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[indexOfMin] > array[i])
                {
                    indexOfMin = i;
                    result = "";
                    result += indexOfMin;

                }
                else if (array[indexOfMin] == array[i])
                {
                    result += ", ";
                    result += i;
                }
            }
            if (result.StartsWith(","))
            {
                result = result.Substring(2);
            }
            if (result.Contains(","))
            {
                Console.WriteLine("Индексы минимальных элементов: " + result);
            }
            else Console.WriteLine("Индекс минимального элемента: " + result);
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