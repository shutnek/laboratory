using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d,k,l,n = 0;
            Console.WriteLine("введите целую величину длинну прямоугольника целую ширину прямоугольника и уелую сторону квадрата");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            n = (a / c) * (b / c);
            l = a * b - n * c * c;
            Console.Write(n);
            Console.WriteLine("столько квадратов поместится в прямоугольник");
            Console.Write(l);
            Console.WriteLine("столько квадратов поместится в прямоугольник");
        }
    }
}
