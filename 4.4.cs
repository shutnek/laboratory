using System;

namespace program4
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
            if ((a!=0) & (b != 0))
            {
                c =(a*a)+(b*b);
                d = (a*a)-(b*b);
                x = (a*a)*(b*b);
                z = (a*a)/(b*b);
                Console.Write("произведение квадратов = ");
                Console.WriteLine(x);
                Console.Write("частное квадратов= ");
                Console.WriteLine(z);
                Console.Write("сумма квадратов= ");
                Console.WriteLine(c);
                Console.Write("разность квадратов= ");
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine("ошибка");
            }
           
           
        }
    }
}
