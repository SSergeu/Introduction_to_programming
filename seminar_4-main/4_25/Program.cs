﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < B; i++){
    result = result * A;    
}

Console.WriteLine(result);