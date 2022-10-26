// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
NaturalNum(num);
void NaturalNum(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNum(num - 1);
}
