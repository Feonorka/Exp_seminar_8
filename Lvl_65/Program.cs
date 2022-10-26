﻿// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
NaturalNum(M, N);

void NaturalNum(int num1, int num2)
{
    if (num1 < num2)
    {
    NaturalNum(num1, num2 - 1);
    Console.Write($"{num2} ");
    }

    if (num1 > num2)
    {
    Console.Write($"{num1} ");
    NaturalNum(num1 - 1, num2);
    }
    if (num1 == num2)
    {
    Console.Write($"{num1} ");
    }
}
