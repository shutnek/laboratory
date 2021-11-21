double a, b, i, l, d, i2 = 0;
Console.WriteLine("Введите а и б при чем а>б");
a = Convert.ToDouble(Console.ReadLine());
b = Convert.ToDouble(Console.ReadLine());

while (a >= b){
    a = a - b;

}
Console.Write("осталась длинна = ");
Console.WriteLine(a);