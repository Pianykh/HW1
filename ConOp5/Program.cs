using System;
using System.Text;

/*
Написать программу определения оценки студента по его рейтингу, на основе следующих правил
|Рейтинг|Оценка|
| 0-19  |  F   |
| 20-39 |  E   |
| 40-59 |  D   |
| 60-74 |  C   |
| 75-89 |  B   |
| 90-100|  A   |
*/

namespace ConOp5
{
    public class Program5
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            char grade;
            Console.WriteLine("Введите рейтинг студента от 0 до 100");
            var rating = Convert.ToInt32(Console.ReadLine());
            if (rating < 0)
            {
                Console.WriteLine("Рейтинг не может быть ниже нуля");
                return;
            }
            else if (rating < 20)
            {
                grade = 'F';
            }
            else if (rating < 40)
            {
                grade = 'E';
            }
            else if (rating < 60)
            {
                grade = 'D';
            }
            else if (rating < 75)
            {
                grade = 'C';
            }
            else if (rating < 90)
            {
                grade = 'B';
            }
            else if (rating <= 100)
            {
                grade = 'A';
            }
            else
            {
                Console.WriteLine("Рейтинг не может быть выше 100");
                return;
            }
            Console.WriteLine("Оценка данного студента: " + grade);
        }
    }
}