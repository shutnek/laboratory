double a, b = 0;
Console.WriteLine("Введите положительных 2 числа");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());
while(a!=0 && b != 0)
{
    if (a > b)
    {
        a = a % b;
    }
    else
    {
        b = b % a;
    }
    

}
Console.WriteLine(a + b);