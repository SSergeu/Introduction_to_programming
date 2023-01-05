string[] SizeWord(string[] array)                    //функция для сортивоки входного массива 
{
    string[] ArrSort = new string[array.Length];     //новый массив размерностью исходного
    int j = 0;                                       //счетчик подходящих под условие элементов массива 
    for (int i = 0; i < array.Length; i++)           //цикл для сравнения всех элементов с условием 
    {
        if (array[i].Length <= 3)                    //условие
        {
            ArrSort[j] = array[i];                   //заполняем новый массив подходящими элементами
            j++;                                     //если условие истинно, увеличиваем счетчик
        }
    };
    Array.Resize(ref ArrSort, j);                    //сокращаем кол-во эл. в новом массиве 
    return ArrSort;                                  //возвращаем новый массив, заполненный нужными элементами
};

string[] array = { "qwerty", "asdfg", "asd", "sada", "qw" };  //задаем массив и заполняем случайными элементами
Console.Write("[" + string.Join(", ", array) + "] -> [" + string.Join(", ", SizeWord(array)) + "] "); //выводим входной и выходной массивы