//перестановки

void rec(string s2, string c) 
{
    string s1;
    if (s2.Length == 0) //выводим с при условии 
        Console.WriteLine(c);
    else
    {
        for (int i = 0; i < s2.Length; i++) //цикл, который перебирает все возможные варианты 
        {
            c += s2[i];
            s1 = s2;
            s1 = s1.Remove(i, 1);
            rec(s1, c);
            c = c.Remove(c.Length - 1, 1);
        }
    }

}

string? s, c, s2;
s = Console.ReadLine(); //считываем строку с консоли 
for (int i = 0; i < s.Length; i++) //запускаем цикл от 0 до кол-ва символов со считанной строки 
{
    c = Convert.ToString(s[i]);  //присваиваем переменной с символ (в зависимости от i)
    s2 = Convert.ToString(s); 
    s2 = s2.Remove(i, 1); //метод удаляет символ с указанной позиции 
    rec(s2, c); //метод
}
