using System;

namespace _6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, c,l = 0;
            b = 3.14;
            
            Console.WriteLine("Введите значение угла в градусах от 0 до 360");
            a= Convert.ToDouble(Console.ReadLine());
            c = (a * b) / 180;
            Console.WriteLine(c);
        }
    }
}
