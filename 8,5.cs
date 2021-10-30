using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d = 0;
            Console.WriteLine("введите целое трехзначное число ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 100;
            c = a % 100;
            a = b + c * 10;

            Console.Write(a);
            Console.WriteLine("");
        }
    }
}
