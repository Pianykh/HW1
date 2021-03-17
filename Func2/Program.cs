using System;
using System.Text;

/*
Вводим число (0-999), получаем строку с прописью числа.
*/

namespace Func2
{
    public class Program2
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число в диапазоне от 0 до 999: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number >= 0 && number < 1000)
            {
                Console.WriteLine(ConvertUnderThousandToString(number));
            }
            else Console.WriteLine("Программа работает в диапазоне только 0-999");
        }
        public static string ConvertUnderThousandToString(int number)
        {
            string[] underTwenty = {"ноль", "один", "два", "три", "четыре", "пять",                         //словарь чисел от 1 до 20
                "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать",
                "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
            string[] hundredNumbers = {"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",   //словарь сотен
                "семьсот", "восемьсот", "девятьсот"};
            string[] upperTwentyDecimal = {"", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",  // словарь десятков
                "семьдесят", "восемьдесят", "девяносто"};
            var resultString = "";                               //в результирующую строку записывается число прописью
            if (number == 0)
            {
                resultString += "ноль";
            }                                                       // идея состоит в разбитии числа на розряды
            if (number >= 100)
            {                                    // здесь определяются сотни
                resultString += hundredNumbers[number / 100] + " "; // добавление в результирующую строку сотни из словаря
                number %= 100;                                      // из числа удаляется уже записаная прописью сотня
            }
            if (number < 20 && number != 0)
            {                       // случай если оставшееся число от 0 до 19
                resultString += underTwenty[number];
            }
            else
            {
                resultString += upperTwentyDecimal[number / 10];    // если оставшееся число больше 19
                if ((number % 10) != 0)
                {                           // если остались единицы от 1 до 9
                    resultString += " " + underTwenty[number % 10];
                }
            }
            return resultString;
        }
    }
}