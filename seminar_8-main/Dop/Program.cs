//Вывести первые N строк треугольника Паскаля
float factorial(int n) //функция факториала
{
    float k = 1;
    for (int i = 1; i <= n; i++)
    {
        k *= i;
    }
    return k;
};

Console.Write("Введите кол-во строк для вывода треугольника Паскаля: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[N, N];

for (int i = 0; i < N; i++)
{
    for (int c = 0; c <= (N - i); c++)
    {
        Console.Write(" ");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" ");
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}
