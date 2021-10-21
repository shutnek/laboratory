using System;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, l, l2 = 0;
            Console.WriteLine("введите значение 3 точек на числовой оси(A B C) (точка C между A и B )");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (b > a)
            {
                l = (c - a) * (b - c);

            }
            else
            {
                l = (c - b) * (a - c);
            }
            Console.Write("произведение длинн AC и BC  = ");
            Console.WriteLine(l);

        }
    }
}
