int N = Convert.ToInt32(Console.ReadLine());

int[] array = new int[N];
int sum =0;
int sum_max = 0;
for (int i=0;i<array.Length;i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i=0;i<array.Length-2;i++)
{
    sum = array[i]+array[i+1]+array[i+2];
    if (sum > sum_max)
        sum_max=sum; 
    sum=0;  
}

Console.WriteLine(sum_max);