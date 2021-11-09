using System;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, l = 0;
            Console.WriteLine("Введите целое положительное трехзначное число");
            a = Convert.ToInt32(Console.ReadLine());
            b = a % 10;
            c = a / 10;
            d = c % 10;
            l = a / 100;
            if ((l < d) && (l < b) && (d < b))
            {

                Console.WriteLine("Истина");

            }
            else
            {
                if ((l > d) && (l > b) && (d > b))
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
}
