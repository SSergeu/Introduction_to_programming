//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.WriteLine("введите количество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int [] arr = new int [M];
for (int i=0;i<arr.Length;i++){
    arr[i]=Convert.ToInt32(Console.ReadLine());
};

int Colvo (int [] array){
    int i = 0;
    for (int j=0;j<array.Length;j++){
        if(array[j]>0) i++;
    }
    return i;
}

Console.WriteLine(Colvo(arr));