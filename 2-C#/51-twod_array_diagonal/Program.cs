// Задача 51: Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 Сумма элементов главной диагонали: 1+9+2 = 12

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
PrintArray(array);

Console.WriteLine($"Сумма элементов побочной диагонали: {SumDiag(array)}");

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
}

int SumDiag(int[,] array)
{
    int sum =0;

    for (int i=0;i<array.GetLength(0);i++)
    {
        sum += array[i,array.GetLength(1)-i-1];
    }

    return sum;
}