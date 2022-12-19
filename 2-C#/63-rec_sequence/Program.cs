// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от 1 до N. N = 5 -> "1, 2, 3, 4, 5" N = 6 -> "1, 2, 3, 4, 5, 6"

System.Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PrintSequenceRec(n));

// void PrintSequence (int N)
// {
//     int i = 1;
//     while (true)
//     {
//         if (i > N) break;
//         Console.Write($"{i}, ");
//         i++;
//     }
// }

string PrintSequenceRec(int N)
{
    if (N==0) return " ";
    return PrintSequenceRec(N-1) + " " + N;
}

