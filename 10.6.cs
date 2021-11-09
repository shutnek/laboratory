using System;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, l = 0;
            Console.WriteLine("Введите  стороны треугольника");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            
            if ((a*a+b*b==c*c) || (((a*a)+(c*c))==b*b) || (b*b+c*c==a*a))
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
