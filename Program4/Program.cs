using System;
using System.Text;

/*
Найти индекс максимального элемента массива.
*/
/*
ПОЯСНЕНИЕ К РЕШЕНИЮ: В условии не сказано какой индекс указывать как индекс максимального элемента,
в том случае, если максимальных элементов несколько. Поэтому данное решение предполагает вывод нескольких
индексов через запятую для таких случаев
*/

namespace Program4
{
    public class Program4
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = CreateArray();
            var indexOfMax = 0;
            var result = "";
            for (var i = 0; i < array.Length; i++)
            {
                if (array[indexOfMax] < array[i])
                {
                    indexOfMax = i;
                    result = "";
                    result += indexOfMax;
                }
                else if (array[indexOfMax] == array[i])
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
                Console.WriteLine("Индексы максимальных элементов: " + result);
            }
            else Console.WriteLine("Индекс максимального элемента: " + result);
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