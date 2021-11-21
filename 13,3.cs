double a, b, i, l,d = 0;
Console.WriteLine("Введите число >0");
a = Convert.ToDouble(Console.ReadLine());
d = 2 * a - 1;
b = 1;
l = b;
for (i = 2; i < d; i++)
{if (l < a * a)
    {
        b = b + 2;
        l = l + (b);
        Console.WriteLine("сумма = ");
        Console.WriteLine(l);
    }
}
