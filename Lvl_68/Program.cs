Console.WriteLine("Введите значение m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return Akkerman(m - 1, 1);
    if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
    return Akkerman(m, n);
}

int res = Akkerman(numberM, numberN);
Console.WriteLine($"Результат работы функции равен: {res}");
