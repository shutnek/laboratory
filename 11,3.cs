using System;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1,y2,y3, l1,l2 = 0;
            Console.WriteLine("Введите  кординаты точки  A B  c");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
             y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
             y3 = Convert.ToDouble(Console.ReadLine());
            l1=Math.Sqrt(((x1-x2)*(x1-x2))+((y1-y2)*(y1-y2)));
            l2=Math.Sqrt(((x1-x3)*(x1-x3))+((y1-y3)*(y1-y3)));
            if (l1 < l2)
            {
                Console.Write("ближе точка b на растоянии ");
                Console.WriteLine(l2-l1);
            }
            
            if (l2 < l1)
            {
                Console.Write("ближе точка c на растоянии ");
                Console.WriteLine(Math.Abs(l1 - l2));
            }
            if (l2 == l1)
            {
                Console.Write("на одинаковом растоянии");
                Console.WriteLine(Math.Abs(l1 - l2));
            }
        }
    }
}
