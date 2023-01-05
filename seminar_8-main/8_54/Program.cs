//Сортировка по убыванию каждой строки в двумерном массиве

void NewArray(int[,] arr) //функция заполнения двумерного массива
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

void ArraySort(int[,] array)  //функция сортировки пузырьком 
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 1; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - i; j++)
            {
                if (array[k, j] < array[k, j + 1])
                {
                    int x = array[k, j];
                    array[k, j] = array[k, j + 1];
                    array[k, j + 1] = x;
                }
            }
        }
    };
};


int[,] array = new int[3, 6];
Console.WriteLine("Исходный массив: ");
NewArray(array);
Console.WriteLine(" ");
ArraySort(array);

for (int i = 0; i < array.GetLength(0); i++) //вывод массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
};

