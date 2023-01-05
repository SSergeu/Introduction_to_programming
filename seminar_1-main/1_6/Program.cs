Console.WriteLine("Введите число: ");
double n = Convert.ToInt32(Console.ReadLine());
int i = 0; // создал счетчик
if(n<0)        //исключил отрицательные числа
    n=n*(-1);

while (i<n) 
    i+=2;

if (i==n)
    Console.WriteLine("Число чётное");
else 
    Console.WriteLine("Число нечётное");

