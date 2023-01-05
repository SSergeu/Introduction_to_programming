// произведение ячеек в матрице 
void NewArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
};


int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] array = new int[2, 2];

NewArray(array1);
Console.WriteLine(" ");
NewArray(array2);
Console.WriteLine("Произведение: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = array1[i, j] * array2[i, j];
        Console.Write(array[i, j]+ " ");
    }
    Console.WriteLine();
};


