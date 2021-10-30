using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, k, l, n = 0;
            Console.WriteLine("введите целую положительную дату года ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a % 100;
            if (b == 0)
            {
                c = a / 100;
            }
            else
            {
                c = a / 100 + 1;
            }

            Console.Write(c);
            Console.WriteLine(" век");

        }
    }
}
