// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
Print(array);
ChangeArray(array);
Print(array);

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
}            

void Print(int[,] array)
{
    Console.Write(" ");
    for (int j = 0; j < array.GetLength(1) - 1; j++) Console.Write("____");
    Console.Write("___");
    System.Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j],3}|");
        System.Console.WriteLine();
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++) Console.Write("___|");
        System.Console.WriteLine();
    }
    Console.WriteLine();
}
void ChangeArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(1); i++) 
        (array[0, i], array[array.GetLength(0) - 1, i]) = ( array[array.GetLength(0) - 1, i], array[0, i]);
}