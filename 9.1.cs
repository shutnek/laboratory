using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d = 0;
            Console.WriteLine("введите целое количество секунд ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a % 60;

            Console.Write(b);
            Console.WriteLine("");
        }
    }
}
