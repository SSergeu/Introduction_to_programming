//найдёт сумму натуральных элементов в промежутке от M до N

Console.WriteLine("Введите M:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int N = Convert.ToInt32(Console.ReadLine());
if (M > N)
{
    while (M > N)
    {
        Console.WriteLine("Введите M:");
        M = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите N:");
        N = Convert.ToInt32(Console.ReadLine());
    }
}

int sum(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    return M + sum(M + 1, N);
}

Console.WriteLine("Cумма: " + sum(M, N));
