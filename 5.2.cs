using System;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, l, l2,S = 0;
            Console.WriteLine("введите значение 3 точек на числовой оси(A B C)");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a > c)
            {
                l = a - c;
            }
            else
            {
                l = c - a;
            }
            if (b > c)
            {
                l2 = b - c;
            }
            else
            {
                l2 = c - b;
            }
S=l+l2
            Console.Write("длина AC = ");
            Console.WriteLine(l);
            Console.Write("длина BC = ");
            Console.WriteLine(l2);
            Console.Write("сумма длин AC и BC = ")
                Console.Write(S)
        }
    }
}
