// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            // Если M равно нулю
    else if (N == 0) return (M * (M + 1)) / 2;       // Если N равно нулю
    else if (M == N) return M;                       // Если M=N
    else if (M < N) return N + SumNumbers(M, N - 1); // Если M<N
    else return N + SumNumbers(M, N + 1);            // Если M>N
}
int res = SumNumbers(M, N);
Console.WriteLine($"Сумма равна: {res}");