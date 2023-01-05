//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void weekends(){
    int a = Convert.ToInt32(Console.ReadLine());
    if(a==6 || a == 7) 
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

weekends();


