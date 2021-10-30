using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("введите целые положительные числа A и B (A > B). ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a / b;


            Console.Write(c);
            Console.WriteLine("");
        }
    }
}
