double a, b, i, l, d = 0;
Console.WriteLine("Введите число >0 и вещественное число");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
l = 1;
d = b;
for (i = 0; i < a; i++)
{
    
        
        l = l + (d);
    d = d * b;
        
    
}
Console.WriteLine("сумма = ");
Console.WriteLine(l);
