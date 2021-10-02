using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            double b = 0;
            double c = 0;
            double d = 0;
            double x = 0;
            double z = 0;

            Console.WriteLine("Введите два ненулевых числа ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if ((a != 0) & (b != 0))
            {
                c = Math.Abs(a) * Math.Abs(b);
                d = Math.Abs(a) + Math.Abs(b);
                x = Math.Abs(a) - Math.Abs(b);
                z = Math.Abs(a) / Math.Abs(b);
                Console.Write("произведение модулей= ");
                Console.WriteLine(c);
                Console.Write("частное модулей= ");
                Console.WriteLine(z);
                Console.Write("сумма модулей= ");
                Console.WriteLine(d);
                Console.Write("разность модулей= ");
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("ошибка");
            }

        }
    }
}
