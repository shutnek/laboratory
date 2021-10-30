using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0;
            Console.WriteLine("введите размер файла в байтах ");
            a = Convert.ToDouble(Console.ReadLine());

            a = a / 1024;


            Console.Write(a);
            Console.WriteLine("килобайт");
        }
    }
}
