using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,d = 0;
            Console.WriteLine("введите целое двухзначное число ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a / 10;
            c = a % 10;
            a = b + (c * 10);

            Console.Write(a);
            Console.WriteLine("- перевернутое");
        }
    }
}
