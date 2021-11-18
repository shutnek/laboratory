using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b = 0;
            Console.WriteLine("Введите 2 числа");
          a=  Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            if(a>2 && b<= 3 ){

                Console.WriteLine("Истина");

            }
            else
            {

                Console.WriteLine("Ложь");
            }
        }
    }
}
