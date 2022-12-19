// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 453 -> 12 45 -> 9

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма чисел в числе равна {SummaRec(N)}");

int SummaRec(int N)
{
    if (N == 0) return 0;
    return N % 10 + SummaRec(N / 10); 
}
 