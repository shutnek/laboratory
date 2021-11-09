using System;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c = 0;
            Console.WriteLine("Введите 3 числа");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            if (a < b && b < c)
            {

                Console.WriteLine("Истина");

            }
            else
            {

                Console.WriteLine("Ложь");
            }
        }
    }
}
