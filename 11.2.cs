using System;

namespace ConsoleApp29
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
            if (a<=b&&a<=c)
            {
                d = b + c;
                Console.WriteLine(d);
                
            }
            else
            {
                if (b <= a && b <= c)
                {
                    d = a + c;
                    Console.WriteLine(d);

                }
                else
                {
                    if (c <= a && c <= b)
                    {
                        d = b + a;
                        Console.WriteLine(d);

                    }

                }
            }

        }   
    }
}
