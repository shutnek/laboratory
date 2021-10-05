using System;

namespace _5._5
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1, x2, y1, y2, l1, x3, y3, l2, l3, p, s, p2 = 0;
            Console.WriteLine("введите  кординаты трех точек");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            l1 = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            l2 = Math.Sqrt(((x3 - x2) * (x3 - x2)) + ((y3 - y2) * (y3 - y2)));
            l3 = Math.Sqrt(((x3 - x1) * (x3 - x1)) + ((y3 - y1) * (y3 - y1)));
            p = l1 + l2 + l3;
            p2 = p / 2;
            s = Math.Sqrt((p2 * (p2 - l1) * (p2 - l2) * (p2 - l3)));
            Console.Write("Периметр = ");
            Console.WriteLine(p);
            Console.Write("Площадь = ");
            Console.Write(s);
        }
    }
}
