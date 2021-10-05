using System;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, l, l2, s, p = 0;
            Console.WriteLine("введите  кординаты двух противоположных вершин");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            if (x1 > x2)
            {
                l = x1 - x2;
                if (y1 > y2)
                {
                    l2 = y1 - y2;
                }
                else
                {
                    l2 = y2 - y1;
                }

            }
            else
            {
                l = x2 - x1;
                if (y1 > y2)
                {
                    l2 = y1 - y2;
                }
                else
                {
                    l2 = y2 - y1;
                }
            }
            s = l * l2;
            p = l + l + l2 + l2;

            Console.Write("площадь  = ");
            Console.WriteLine(s);
            Console.Write("периметр  = ");
            Console.Write(p);
        }
    }
}
