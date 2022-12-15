// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это невозможно,
// программа должна вывести сообщение для пользователя.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
FillArray(array);
Print(array);
Print (ChangeArray(array));
Reverse(array);
Print (array);

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
int [, ] ChangeArray(int[, ] array)
{
    int [,] temp = new int [rows, cols];

    for (int i = 0; i < array.GetLength(1); i++)
        for (int j = 0; j < array.GetLength(0); j++) 
            temp[j, i]= array [i, j];
    return temp;
}
void Reverse(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0) - 1; i++)

    for (int j = i + 1; j < Array.GetLength(1); j++)
        (Array[i, j], Array[j, i]) = (Array[j, i], Array[i, j]);

}