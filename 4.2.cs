using System;

namespace номер3
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0;
            double p = 3.14;
            double c = 0;
            Console.WriteLine("Введите диаметр ");
            d = Convert.ToDouble(Console.ReadLine());
            c = p*d;
            Console.Write("Длина окружности ");
            Console.Write(c); 
        }
    }
}
