using System;
using System.Text;

/*
Получить строковое название дня недели по номеру дня.
*/

namespace Func1
{
    public class Program1
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите номер дня недели от 1 до 7");
            var numberOfDay = Convert.ToInt16(Console.ReadLine());
            if (numberOfDay > 0 && numberOfDay < 8)
            {
                string[] daysOfWeek = {"Понедельник", "Вторник", "Среда",
                    "Четверг", "Пятница", "Суббота", "Воскресение"};
                Console.WriteLine("День недели под номером " + numberOfDay + " - " + daysOfWeek[numberOfDay - 1]);
            }
            else Console.WriteLine("Номер дня может быть от 1 до 7");
        }
    }
}