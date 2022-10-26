// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int SqrOfDig(int num, int power)
{
int result = num;
if (power == 0) 
result = num * SqrOfDig(num, power - 1); 
return result;
}

Console.WriteLine("Введите значение 1: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int sqr = Convert.ToInt32(Console.ReadLine());

int ressqr = SqrOfDig(number, sqr);
Console.WriteLine($"Число {number} возведенное в степень {sqr} равно: {ressqr}");

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int deegreNumber = DegreeNumber (number1, number2);
Console.WriteLine (deegreNumber);
int DegreeNumber (int numb1, int numb2)
{
return numb2 == 0 ? 1 : numb1 * DegreeNumber (numb1, numb2-1);
}