using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, d, l = 0;
            Console.WriteLine("Введите   целое число");
            a = Convert.ToDouble(Console.ReadLine());
            b = a % 2;
            if (b == 0 && a > 0)
            {
                Console.WriteLine("Положительное четное число");
            }
            if (b == 0 && a <0)
            {
                Console.WriteLine("Отрицательное четное число");
            }
            if (b != 0 && a < 0)
            {
                Console.WriteLine("Отрицательное нечетное число");
            }
            if (b != 0 && a > 0)
            {
                Console.WriteLine("Положительное нечетное число");
            }
            if (a==0)
            {
                Console.WriteLine("нуливое число");
            }

        }
    }
}
