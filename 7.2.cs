using System;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, c, l = 0;
            b = 3.14;

            Console.WriteLine("Введите значение угла в радианах от 0 до 2 pi");
            a = Convert.ToDouble(Console.ReadLine());
            c = (a * 180) / b;
            Console.WriteLine(c);
        }
    }
}
