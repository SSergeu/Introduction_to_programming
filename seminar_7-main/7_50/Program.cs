// Нахождение элемента в массиве 

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

int[,] array = new int[4, 5];
NewMatrix(array);
Console.WriteLine("Введите индекс строки: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

if ((i < 0 || i > 3) && (j < 0 || j > 4))
{
    Console.WriteLine("Такого элемента нет");
}
else
{
    Console.WriteLine(array[i, j]);
}
