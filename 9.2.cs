using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d = 0;
            Console.WriteLine("введите целое число от 1 до 365 ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a % 7;

            Console.Write(b);
            Console.WriteLine("");
        }
    }
}
