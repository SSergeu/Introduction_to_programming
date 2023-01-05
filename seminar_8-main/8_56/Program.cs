//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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

int[,] array = new int[5, 4];
NewArray(array);

int sum = 0;
int sum_min = 0;
int index_min = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == 0)
        {
            sum_min = sum_min + array[i, j];
        }
        sum = sum + array[i, j];
    }
    if (sum < sum_min)
    {
        sum_min = sum;
        index_min = i+1;
    }
    sum = 0;
};
Console.WriteLine("Строка с наименьшей суммой элементов: " + index_min);