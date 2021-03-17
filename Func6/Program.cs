using System;
using System.Text;
/*
**Для задания 3 расширить диапазон до 999 миллиардов
*/

namespace Func6
{
    public class Program6
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите число прописью от нуля до девятьсот девяносто девяти миллиардов " +
                              "девятьсот девяносто девяти миллионов девятьсот девяносто девяти тысяч " +
                              "девятьсот девяносто девяти");
            var stringNumber = Console.ReadLine();
            Console.WriteLine(UpperThousandStringToInt(stringNumber));
        }
        public static long UpperThousandStringToInt(string stringNumber)
        {      // здесь идея так же суммы числа по разрядам
            long result = 0;
            long tempResult = 0;                                                // переменная для записи разрядов отдельно
            var stringNumbersArray = stringNumber.Split(' ');        // разбитие входящего числа прописью на массив слов
            for (var i = 0; i < stringNumbersArray.Length; i++)
            {               // прогон по массиву из воходящих слов(чисел прописью)
                tempResult += UnderThousandStringToInt(stringNumbersArray[i]);  // здесь записываются числа до 999
                if (stringNumbersArray[i].StartsWith("миллиард"))
                {             // если встречается слово "миллиард"
                    result += tempResult * 1000000000;                          // число до слова миллиард умножаем на миллиард
                    tempResult = 0;                                             // обнуление количества данного разряда(миллиардов)
                }
                else if (stringNumbersArray[i].StartsWith("миллион"))
                {       // далее аналогично для миллионов...
                    result += tempResult * 1000000;
                    tempResult = 0;
                }
                else if (stringNumbersArray[i].StartsWith("тысяч"))
                {         //..и тысяч
                    result += tempResult * 1000;
                    tempResult = 0;
                }
                else if (i == stringNumbersArray.Length - 1)
                {                // если после числа нет слова обозначающего разряд...
                    result += tempResult;                                       //.. происходит добавление этого числа к результату
                }
            }
            if (stringNumber.Contains("одна"))
            {              //исключение для измененного числителя тысяч..
                result += 1000;                              //..так как алгоритм выше не "видит" число записанные как "одна"
            }
            if (stringNumber.Contains("две"))
            {               //исключение для измененного числителя тысяч
                result += 2000;                              //..так как алгоритм выше не "видит" число записанные как "две"
            }
            return result;
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
            for (var i = 0; i < stringNumbersArray.Length; i++)// прогон по массиву входящих слов(из входящей строки)
            {
                for (var k = 0; k < hundredNumbers.Length; k++)// прогон по словарю сотен
                {
                    if (stringNumbersArray[i].Equals(hundredNumbers[k])) // сравнение слова из массива входящих слов со словарем
                    {
                        result += (k * 100); // если слова совпали добавляем к числу-ответу это слово в виде числа
                    }
                } // далее по аналогии
                // числа от 1 до 19
                for (var k = 0; k < underTwenty.Length; k++)
                {
                    if (stringNumbersArray[i].Equals(underTwenty[k]))
                    {
                        result += k;
                    }
                }
                for (var k = 0; k < upperTwentyDecimal.Length; k++) // десятки от 20 до 90
                {
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