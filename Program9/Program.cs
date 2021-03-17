using System;
using System.Text;

/*
Отсортировать массив (пузырьком (Bubble), выбором (Select), вставками (Insert))
*/

namespace Program9
{
    public class Program9
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите цифру соответствующую желаемому типу сортировки.");
            Console.WriteLine("1 - сорт-ка пузырьком. 2 - сорт-ка выбором. 3 сорт-ка - вставками");
            int method = Convert.ToInt16(Console.ReadLine());
            var array = CreateArray();
            if (method == 1)
            {
                BubbleSort(array);
            }
            else if (method == 2)
            {
                SelectionSort(array);
            }
            else if (method == 3)
            {
                InsertionSort(array);
            }
            Console.WriteLine("Отсортированный массив: ");
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

        public static void BubbleSort(int[] array)
        {

            for (var k = 0; k < array.Length - 1; k++)
            {
                var isSorted = true;
                for (var i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        array[i] = array[i] ^ array[i + 1];
                        array[i + 1] = array[i] ^ array[i + 1];
                        array[i] = array[i] ^ array[i + 1];
                        isSorted = false;
                    }
                }
                if (isSorted) return;
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var minIndex = i;
                for (var k = i + 1; k < array.Length; k++)
                {
                    if (array[k] < array[minIndex])
                    {
                        minIndex = k;
                    }
                }
                if (i != minIndex)
                {
                    array[i] = array[i] ^ array[minIndex];
                    array[minIndex] = array[i] ^ array[minIndex];
                    array[i] = array[i] ^ array[minIndex];
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var k = i; k > 0; k--)
                {
                    if (array[k] < array[k - 1])
                    {
                        array[k] = array[k] ^ array[k - 1];
                        array[k - 1] = array[k] ^ array[k - 1];
                        array[k] = array[k] ^ array[k - 1];
                    }
                }
            }
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