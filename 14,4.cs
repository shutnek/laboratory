double a, b, k, s, d, i2 = 0;
Console.WriteLine("Введите процент вклада от 0 до 25  ");
a = Convert.ToDouble(Console.ReadLine());
k = 1;
s = 1000;
while (s <= 1100)
{
    k++;
    s = s + s * a/100;

}

Console.WriteLine("кол-во месяцев");
Console.WriteLine(k);
Console.WriteLine("превысит на");
Console.WriteLine(s);