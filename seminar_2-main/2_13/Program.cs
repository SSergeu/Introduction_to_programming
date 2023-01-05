// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
void Number()
{   
    int n = Convert.ToInt32(Console.ReadLine());
    if (n<100)
        Console.WriteLine("третьей цифры нет");
    else 
        Console.WriteLine(Convert.ToString(n)[2]);
}

Number();
