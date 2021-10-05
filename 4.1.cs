using System;

namespace hip
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int s = 0;
            int p = 0;
            Console.WriteLine("Введите длину сторон прямоугольника");
            a= Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            s = a * b;
            p = 2 * (a + b);
            Console.Write("площадь равна ");
            Console.WriteLine(s);
            Console.Write("Периметр равен ");
            Console.WriteLine(p);
        }
    }
}
