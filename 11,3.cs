using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите  три целых числа");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(a - b) < Math.Abs(a - c))
            {
                Console.Write("ближе точка b на растоянии ");
                Console.WriteLine(Math.Abs(a - b));
            }
            else
            {
                Console.Write("ближе точка c на растоянии ");
                Console.WriteLine(Math.Abs(a - c));
            }
        }
    }
}
