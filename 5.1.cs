using System;

namespace _5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, l = 0;
            Console.WriteLine("введите  кординаты двух точек");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));

            Console.Write("длина = ");
            Console.Write(l);
        }
    }
}
