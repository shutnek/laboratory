using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a, c, l, n = 0;
            Console.WriteLine("Введите текущи вес конфет их цену и какого веса посчитать цену");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            l = b / a;
            n = l * c;

            Console.WriteLine("1 kg=  ");
            Console.WriteLine(l);
            Console.Write(c);
            Console.Write(" kg=  ");
            Console.WriteLine(n);
        }
    }
}
