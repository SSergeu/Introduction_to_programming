//Напишите программу, которая покажет количество чётных чисел в массиве

Console.Clear();
void NewArray(int [] array)
{
    for (int i =0; i <array.Length;i++){
        array[i] = new Random().Next(0,1000);
    }
}

int Positive (int [] array)
{
    int n =0;
    for (int i = 0; i < array.Length;i++){
        if (array[i]%2==0){
            n++;
        }
    }
    return n;
}

int[] arr = new int[5];
NewArray(arr);
Console.Write("["+string.Join(",",arr)+"]");
Console.WriteLine(" -> "+Positive(arr));
