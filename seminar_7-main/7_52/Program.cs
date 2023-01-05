void NewMatrix(int[,] arr)
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

void AverageValue(int[,] arr)
{
    double sum = 0;
    double k = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
            k++;
        }
         if (i < arr.GetLength(1) - 1)
        {
            Console.Write(sum / k + "; ");
        }
        else
        {
            Console.Write(sum / k + ".");
        }
    }
};

int[,] array = new int[4, 5];
NewMatrix(array);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
AverageValue(array);

