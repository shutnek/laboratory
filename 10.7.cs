using System;

namespace ConsoleApp27
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

            if ((a<b+c) && (b<a+c) && (c<a+b))
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
