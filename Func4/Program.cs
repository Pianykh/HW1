using System;
using System.Text;

/*
Найти расстояние между двумя точками в двумерном декартовом пространстве.
*/

namespace Func4
{
    public class Program4
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите x-координату первой точки");
            var firstPointX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y-координату первой точки");
            var firstPointY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите x-координату второй точки");
            var secondPointX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите y-координату второй точки");
            var secondPointY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расстояние между точками: ");
            Console.WriteLine(CountDistance(firstPointX, firstPointY, secondPointX, secondPointY));
        }
        public static double CountDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            return Math.Sqrt((secondPointX - firstPointX) * (secondPointX - firstPointX) +
                             (secondPointY - firstPointY) * (secondPointY - firstPointY));
        }
    }
}