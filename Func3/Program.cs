using System;
using System.Text;

/*
Вводим строку, которая содержит число, написанное прописью (0-999).
Получить само число
*/

namespace Func3
{
    public class Program3
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число прописью от нуля до девятсот девяносто девяти");
            var stringNumber = Console.ReadLine();
            Console.WriteLine(UnderThousandStringToInt(stringNumber));
        }
        public static int UnderThousandStringToInt(string stringNumber)
        {
            string[] underTwenty =
            {
                "ноль", "один", "два", "три", "четыре", "пять",
                "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать",
                "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"
            };
            string[] hundredNumbers =
            {
                "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",
                "семьсот", "восемьсот", "девятьсот"
            };
            string[] upperTwentyDecimal =
            {
                "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",
                "семьдесят", "восемьдесят", "девяносто"
            };
            var result = 0; // идея состоит в разбитии входной строки на массив слов(цифр прописью)
            var stringNumbersArray = stringNumber.Split(' '); // разбитие входящего числа прописью на массив слов
            for (var i = 0; i < stringNumbersArray.Length; i++)
            {
                // прогон по массиву входящих слов(из входящей строки)
                for (var k = 0; k < hundredNumbers.Length; k++)
                {
                    // прогон по словарю сотен
                    if (stringNumbersArray[i].Equals(hundredNumbers[k]))
                    {
                        // сравнение слова из массива входящих слов со словарем
                        result += (k * 100); // если слова совпали добавляем к числу-ответу это слово в виде числа
                    }
                } // далее по аналогии
                for (var k = 0; k < underTwenty.Length; k++)
                {
                    // числа от 1 до 19
                    if (stringNumbersArray[i].Equals(underTwenty[k]))
                    {
                        result += k;
                    }
                }
                for (var k = 0; k < upperTwentyDecimal.Length; k++)
                {
                    // десятки от 20 до 90
                    if (stringNumbersArray[i].Equals(upperTwentyDecimal[k]))
                    {
                        result += (k * 10);
                    }
                }
            }
            return result;
        }
    }
}