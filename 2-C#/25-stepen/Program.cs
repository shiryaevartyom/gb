// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵);    2, 4 -> 16

Console.WriteLine("Введите целое число, возводимое в степень:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите целое число, саму степень:");
int step = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {n} в степени {step}: {exponentiation (n, step)}");;


int exponentiation (int n, int step)
{
    int result = 0;
    for (int i=0; i<step; i ++)
        {
            result = result + n;
        }
    return result;
}

