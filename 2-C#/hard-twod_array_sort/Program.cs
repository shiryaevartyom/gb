// Задача HARD SORT необязательная. Считается за три обязательных Задайте двумерный массив из целых чисел.
// Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив: 1 4 7 2 5 9 10 3 После сортировки 1 2 3 4 5 7 9 10

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
ChangeArray(array);
Console.WriteLine("Измененный массив, у которых оба индекса нечётные, и замените эти элементы на их квадраты:");
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-20, 21);

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    int min = 0;

    int[] sortArray = new int[rows * cols];

    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            sortArray
}
