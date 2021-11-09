using System;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите целое положительное двухзначное  число");
            a = Convert.ToDouble(Console.ReadLine());
            b = a % 2;

            if ((b == 0) && (a < 100) && (a > 9))
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
