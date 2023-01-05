//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void Number3 ()
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Convert.ToString(n)[1]);    
}

Number3();

