using System;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите  два целых числа");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if (a == b)
            {
                a = 0;
                b = 0;
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                if (a > b)
                {
                    b = a;
                    Console.WriteLine(a);
                    Console.WriteLine(b);
                }
                else
                {
                    a = b;
                    Console.WriteLine(a);
                    Console.WriteLine(b);

                }
            }
        }
    }
}
