//Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double arr_Max(double [] array){
    double max = array[0];
    for(int i=1;i<array.Length;i++){
        if (max<array[i]){
            max=array[i];
        }
    }
    return max;
}

double arr_Min(double [] array){
    double min = array[0];
    for(int i=1;i<array.Length;i++){
        if (min>array[i]){
            min=array[i];
        }
    }
    return min;
}

double[] array = new double [5];
for (int i = 0; i<array.Length; i++){
    array[i] = Math.Round(new Random().Next(0,100) + new Random().NextDouble(),2);
}
Console.WriteLine("["+string.Join("; ",array)+"]"+"->");
Console.WriteLine(arr_Max(array)-arr_Min(array));


