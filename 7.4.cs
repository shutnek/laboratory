using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, c, l, n = 0;
            Console.WriteLine("Введите скорость первого и второго автомобиля и растояние между ними и время которое они движутся ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            l = Convert.ToDouble(Console.ReadLine());
            n = (a * l) + (b * l) + c;
            Console.Write("они будут на растояние = ");
            Console.WriteLine(n);
        }
    }
}
