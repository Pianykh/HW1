using System;
using System.Text;

/*
Сделать реверс массива (массив в обратном направлении)
*/
/*
ПОЯСНЕНИЕ К РЕШЕНИЮ: В задании явно не указано что нужно создать новый массив, следовательно я решил задачу
не создавая новый массив, а поменял элементы в текущем массиве.
*/

namespace Program6
{
    public class Program6
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            var array = CreateArray();
            var endPointer = 0;
            for (var startPointer = array.Length - 1;
                startPointer >= array.Length / 2 + array.Length % 2; startPointer--, endPointer++)
            {
                array[endPointer] = array[endPointer] ^ array[startPointer];    // XOR-обмен, дабы избежать ввода еще одной переменной
                array[startPointer] = array[endPointer] ^ array[startPointer];
                array[endPointer] = array[endPointer] ^ array[startPointer];
            }
            Console.WriteLine("Массив повернут в обратном порядке:");
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