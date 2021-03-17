using System;
using System.Text;

/*
**Для задания 2 расширить диапазон до 999 миллиардов
*/

namespace Func5
{
    public class Program5
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число от 0 до 999999999999");
            var number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(ConvertOverThousandNumberToString(number));
        }

        public static string ConvertOverThousandNumberToString(long number)
        {
            //здесь идея так же в разбитии числа на разряды
            var resultString = "";
            if (number > 999999999)
            {
                // здесь миллиарды
                resultString +=
                    ConvertUnderThousandToString(number / 1000000000) +
                    " миллиард"; // если есть миллиарды записываем чило миллиардов и добавляем "миллиард"
                if (number / 1000000000 % 100 > 9 && number / 1000000000 % 100 < 20)
                {
                    //определение окончания слова "миллиард в зависимости от последней цифры"
                    resultString += "ов ";
                }
                else if (number / 1000000000 % 10 >= 5 || number / 1000000000 % 10 == 0)
                {
                    resultString += "ов ";
                }
                else if (number / 1000000000 % 10 >= 2)
                {
                    resultString += "а ";
                }
                else resultString += " ";

                number %= 1000000000; // удаление из числа миллиардов которые уже записаны
            }

            if (number > 999999)
            {
                resultString += ConvertUnderThousandToString(number / 1000000) + " миллион"; //далее по аналогии
                if (number / 1000000 % 100 > 9 && number / 1000000 % 100 < 20)
                {
                    resultString += "ов ";
                }
                else if (number / 1000000 % 10 >= 5 || number / 1000000 % 10 == 0)
                {
                    resultString += "ов ";
                }
                else if (number / 1000000 % 10 >= 2)
                {
                    resultString += "а ";
                }
                else resultString += " ";

                number %= 1000000;
            }

            if (number > 999)
            {
                resultString += ConvertUnderThousandToString(number / 1000) + " тысяч";
                if (number / 1000 % 100 > 9 && number / 1000 % 100 < 20)
                {
                    resultString += " ";
                }
                else if (number / 1000 % 10 == 1)
                {
                    resultString += "а ";
                }
                else if (number / 1000 % 10 == 2)
                {
                    resultString += "и ";
                }
                else if (number / 1000 % 10 < 5 && number / 1000 % 10 > 0)
                {
                    resultString += "и ";
                }
                else resultString += " ";

                if (resultString.Contains("один тысяча"))
                {
                    // частный случай изменения окончания числителя в тысячах
                    resultString = resultString.Replace("один тысяча", "одна тысяча");
                }

                if (resultString.Contains("два тысячи"))
                {
                    // частный случай изменения окончания числителя в тысячах
                    resultString = resultString.Replace("два тысячи", "две тысячи");
                }
                number %= 1000;
            }

            if (number > 0)
            {
                resultString += ConvertUnderThousandToString(number);
            }
            return resultString;
        }

        public static string ConvertUnderThousandToString(long longNumber)
        {
            string[] underTwenty = {"ноль", "один", "два", "три", "четыре", "пять",                         //словарь чисел от 1 до 20
                "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать",
                "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать"};
            string[] hundredNumbers = {"", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот",   //словарь сотен
                "семьсот", "восемьсот", "девятьсот"};
            string[] upperTwentyDecimal = {"", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят",  // словарь десятков
                "семьдесят", "восемьдесят", "девяносто"};
            var resultString = "";                               //в результирующую строку записывается число прописью
            if (longNumber == 0)
            {
                resultString += "ноль";
            }                                                           // идея состоит в разбитии числа на розряды
            if (longNumber >= 100)
            {                                    // здесь определяются сотни
                resultString += hundredNumbers[longNumber / 100] + " "; // добавление в результирующую строку сотни из словаря
                longNumber %= 100;                                      // из числа удаляется уже записаная прописью сотня
            }
            if (longNumber < 20 && longNumber != 0)
            {                       // случай если оставшееся число от 0 до 19
                resultString += underTwenty[longNumber];
            }
            else
            {
                resultString += upperTwentyDecimal[longNumber / 10];    // если оставшееся число больше 19
                if ((longNumber % 10) != 0)
                {                           // если остались единицы от 1 до 9
                    resultString += " " + underTwenty[longNumber % 10];
                }
            }
            return resultString;
        }
    }
}