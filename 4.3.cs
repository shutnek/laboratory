using System;

namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            Console.WriteLine("Введите два числа ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = (a + b) / 2;
            Console.Write("Среднее арефмитическое= ");
            Console.Write(c);
        }
    }
}
