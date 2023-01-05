//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m,n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arr[i, j] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
        Console.Write(arr[i, j]+" ");
    }
    Console.WriteLine();
}

Console.WriteLine("[" + string.Join("; ", arr) + "]");