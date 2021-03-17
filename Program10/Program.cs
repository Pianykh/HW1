using System;
using System.Text;

/*
 **Отсортировать массив (Quick, Merge, Shell, Heap)
*/

namespace Program10
{
    public class Program10
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите цифру соответствующую желаемому типу сортировки.");
            Console.WriteLine("1 - сорт-ка быстрая. 2 - сорт-ка слиянием. 3 - сорт-ка Шелла. 4 - сорт-ка кучей");
            int method = Convert.ToInt16(Console.ReadLine());
            var array = CreateArray();
            if (method == 1)
            {
                QuickSort(array, 0, array.Length - 1);
            }
            else if (method == 2)
            {
                MergeSort(array, 0, array.Length);
            }
            else if (method == 3)
            {
                ShellSort(array);
            }
            else if (method == 4)
            {
                HeapSort(array);
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

        public static void QuickSort(int[] array, int left, int right)
        {
            if (array.Length == 0) return;
            if (left > right) return;
            var coreElement = array[(left + right) / 2];
            var i = left;
            var j = right;
            while (i <= j)
            {
                while (array[i] < coreElement)
                {
                    i++;
                }
                while (array[j] > coreElement)
                {
                    j--;
                }
                if (i <= j)
                {
                    array[i] = array[i] ^ array[j];
                    array[j] = array[i] ^ array[j];
                    array[i] = array[i] ^ array[j];
                    i++;
                    j--;
                }
            }
            if (left < j) QuickSort(array, left, j);
            if (i < right) QuickSort(array, i, right);
        }


        public static void MergeSort(int[] array, int left, int right)
        {
            if (right <= left) return;
            var mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, mid, right);
        }

        public static void Merge(int[] array, int left, int mid, int right)
        {
            var leftArray = new int[mid - left + 1];
            var rightArray = new int[right - mid];
            for (var i = 0; i < leftArray.Length; i++)
                leftArray[i] = array[left + i];
            for (var i = 0; i < rightArray.Length; i++)
                rightArray[i] = array[mid + i + 1];
            var leftPointer = 0;
            var rightPointer = 0;
            for (var i = left; i < right + 1; i++)
            {
                if (leftPointer < leftArray.Length && rightPointer < rightArray.Length)
                {
                    if (leftArray[leftPointer] < rightArray[rightPointer])
                    {
                        array[i] = leftArray[leftPointer];
                        leftPointer++;
                    }
                    else
                    {
                        array[i] = rightArray[rightPointer];
                        rightPointer++;
                    }
                }
                else if (leftPointer < leftArray.Length)
                {
                    array[i] = leftArray[leftPointer];
                    leftPointer++;
                }
                else if (rightPointer < rightArray.Length)
                {
                    array[i] = rightArray[rightPointer];
                    rightPointer++;
                }
            }
        }

        public static void ShellSort(int[] array)
        {
            for (var step = array.Length / 2; step > 0; step /= 2)
            {
                for (var i = step; i < array.Length; i += 1)
                {
                    var temp = array[i];
                    int j;
                    for (j = i; j >= step && array[j - step] > temp; j -= step)
                    {
                        array[j] = array[j - step];
                    }
                    array[j] = temp;
                }
            }
        }

        public static void HeapSort(int[] array)
        {
            for (var i = array.Length / 2 - 1; i >= 0; i--)
            {
                Heaping(array, array.Length, i);
            }
            for (var i = array.Length - 1; i >= 0; i--)
            {
                var temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                Heaping(array, i, 0);
            }
        }

        public static void Heaping(int[] array, int size, int root)
        {
            var max = root;
            var left = 2 * root + 1;
            var right = 2 * root + 2;
            if (left < size && array[left] > array[max])
                max = left;
            if (right < size && array[right] > array[max])
                max = right;
            if (max != root)
            {
                array[root] = array[root] ^ array[max];
                array[max] = array[root] ^ array[max];
                array[root] = array[root] ^ array[max];
                Heaping(array, size, max);
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