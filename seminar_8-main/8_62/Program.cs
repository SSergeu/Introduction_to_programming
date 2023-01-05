
int[,] array = new int[4, 4];
int N = 4, M = 4;
int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;

int k = 1;
int i = 0;
int j = 0;

while (k <= N * M)
{
    array[i, j] = k;
    if (i == Ibeg && j < M - Jfin - 1)
        j++;
    else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        i++;
    else if (i == N - Ifin - 1 && j > Jbeg)
        j--;
    else
        i--;
    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        ++Ibeg;
        ++Ifin;
        ++Jbeg;
        ++Jfin;
    }
    k++;
};

for (int l = 0; l < array.GetLength(0); l++)
{
    for (int n = 0; n < array.GetLength(1); n++)
    {
        if (array[l, n] < 10)
            Console.Write("0"+ array[l, n] + " ");
        else
            Console.Write(array[l, n] + " ");
    }
    Console.WriteLine(" ");
}