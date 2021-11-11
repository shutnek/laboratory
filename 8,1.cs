using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d = 0;
            int l =1024;
            Console.WriteLine("введите размер файла в байтах(целое число) ");
            a = Convert.ToInt32(Console.ReadLine());
            b=a % 1024;
if(b==0){
    c = a / l;
    
}
    else{
       d = a / l; 
       c=d + 1;
        
    }

            


            Console.Write(c);
            Console.WriteLine(" килобайт");
        }
    }
}
