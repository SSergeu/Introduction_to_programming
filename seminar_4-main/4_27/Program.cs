//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (n>0){
    result = result + (n % 10);
    n = n /10;
}

Console.WriteLine(result);