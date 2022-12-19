// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии. A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8 

Console.Write("Введите натуральное число A: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Stepen(M, N));

int Stepen(int A, int B)
{
    if (B == 0) return 1; // любое число возведенное в степень 0 = 1
    return ( A * Stepen (A , B-1) );
}