//Сдвиг массива на К элементов
void New_Arr(int[] array){
    for (int i=0;i<array.Length;i++){
        array[i]= new Random().Next(1,10);
    }
}
Console.WriteLine("Введите размерность массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] arr = new int[N];
New_Arr(arr);
Console.WriteLine("["+string.Join(", ",arr)+"]");
Console.WriteLine("Введите K: ");
int K = Convert.ToInt32(Console.ReadLine());
if (K>0){ 
    for (int i=0;i<K;i++){
        int n=arr[N-1];
        for(int j=N-1;j>0;j--){
            arr[j]=arr[j-1];
        }    
        arr[0]= n;
    }
}   
else {
    K = K*(-1);
    for (int i=0;i<K;i++){
        int n=arr[0];
        for(int j=0;j<arr.Length-1;j++){
            arr[j]=arr[j+1];
        }    
        arr[N-1]= n;
    }
}

Console.WriteLine("["+string.Join(", ",arr)+"]");

