// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101 3  -> 11 2  -> 10

Console.WriteLine("Введите десятичное число:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Двоичная запись числа {num} : {ToBin(num)}");

string ToBin (int n )
{
    int r = 0;
    string result = string.Empty;
    do
    {
       r = n % 2;
       result = Convert.ToString(n%2) + result;
       n = n / 2;
    }
    while ( n > 0 );
    return result;
}
