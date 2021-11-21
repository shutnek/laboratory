double N, F, F1, F2, K = 0;
Console.WriteLine("Введите число N>1:");
N = Convert.ToDouble(Console.ReadLine());
F1= 1;
F2= 1;
F= 0;
K= 2;





while (F < N)
{
    K++;
    F = F2 + F1;
    F2 = F1;
    F1 = F;

   
}
Console.WriteLine(K);


