using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, l,t,u = 0;
            Console.WriteLine("Введите целое положительное четырехзначное число");
            a = Convert.ToInt32(Console.ReadLine());
            b = a % 10;
            c = a / 10;
            d = c % 10;
            l = a / 100;
            t = l % 10;
            u = l / 10;
            if ((b==u) && (d==t) )
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
