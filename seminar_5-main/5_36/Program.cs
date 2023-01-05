//Найдите сумму элементов, стоящих на нечётных позициях массива
Console.Clear();
void NewArray (int [] array) {
    for (int i = 0;i<array.Length;i++){
        array[i]= new Random().Next(1,99);
    }
}

int Sum_odd(int [] array){
    int sum = 0;
    for(int i = 1; i<array.Length;i+=2){
        sum+=array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
NewArray(arr);
Console.WriteLine("["+string.Join(",",arr)+"]");
Console.WriteLine(Sum_odd(arr));
