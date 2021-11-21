// See https://aka.ms/new-console-template for more information
double a, b,i,l = 0;
Console.WriteLine("Введите число >0");
a = Convert.ToDouble(Console.ReadLine());
b=1.1;
l = b;
for (i = 1; i < a; i++) 
{
l= l * (b + i / 10);
}
Console.WriteLine("произведение = ");
Console.WriteLine(l);