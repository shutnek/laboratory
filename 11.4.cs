using System;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите  два целых числа");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if(a>0 && b > 0)
            {
                Console.WriteLine("1 четверть");
            }
            if (a < 0 && b > 0)
            {
                Console.WriteLine("4 четверть");
            }
            if (a < 0 && b < 0)
            {
                Console.WriteLine("3 четверть");
            }
            if (a > 0 && b < 0)
            {
                Console.WriteLine("2 четверть");
            }
        }
    }
}
