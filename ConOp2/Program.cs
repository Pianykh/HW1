using System;
using System.Text;

/*
Определить какой четверти принадлежит точка с координатами (х,у)
*/

namespace ConOp2
{
    public class Program2
    {
        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите х-координату точки");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y-координату точки");
            var y = Convert.ToInt32(Console.ReadLine());
            var quarter = 0;
            if (x > 0 && y > 0)
            {
                quarter = 1;
            }
            else if (x > 0 && y < 0)
            {
                quarter = 2;
            }
            else if (x < 0 && y < 0)
            {
                quarter = 3;
            }
            else if (x < 0 && y > 0)
            {
                quarter = 4;
            }
            if (quarter != 0)
            {
                Console.WriteLine("Точка с координатами (" + x + ", " + y + "), расположена на " + quarter + " четверти");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Точка с координатами (" + x + ", " + y + "), расположена в начале координат");
            }
            else if (x == 0)
            {
                Console.WriteLine("Точка с координатами (" + x + ", " + y + "), расположена на оси Y");
            }
            else
            {
                Console.WriteLine("Точка с координатами (" + x + ", " + y + "), расположена на оси X");
            }
        }
    }
}