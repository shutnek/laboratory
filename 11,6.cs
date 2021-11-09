using System;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите  целое число 1-999");
            a = Convert.ToDouble(Console.ReadLine());
            b = a % 2;
            if (b == 0 && a <=9)
            {
                Console.WriteLine(" четное однозначное число");
            }
            if (b != 0 && a <= 9)
            {
                Console.WriteLine(" нечетное однозначное число");
            }
            if (b == 0 && a <= 99&&a>9)
            {
                Console.WriteLine(" четное двухзначное число");
            }
            if (b != 0 && a <= 99 && a > 9)
            {
                Console.WriteLine(" нечетное двухзначное число");
            }
            if (b == 0 && a <= 999 && a > 99)
            {
                Console.WriteLine(" четное трехзначное число");
            }
            if (b != 0 && a <= 999 && a > 99)
            {
                Console.WriteLine(" нечетное трехзначное число");
            }
        }
    }
}
