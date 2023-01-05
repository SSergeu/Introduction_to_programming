//трехмерный массив

int[,,] array = new int[2, 2, 2];
int n = 9;
array[0, 0, 0] = n;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {   
            n++;
            array[i, j, k] = n;
            Console.Write(array[i, j, k] + "(" + i + "," + j + "," + k + ") ");
        }
        Console.WriteLine(" ");
    }
};