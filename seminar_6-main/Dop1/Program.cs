//Транспонированием исходной матрицы относительно горизонтали

void NewArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
};

Console.Write("Количество строк: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int M = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[N, M];
Console.WriteLine();
Console.WriteLine("Исходный массив: ");
NewArray(arr);
Console.WriteLine(" ");
for (int i = arr.GetLength(0)-1; i >-1; i--)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine(" ");
}

