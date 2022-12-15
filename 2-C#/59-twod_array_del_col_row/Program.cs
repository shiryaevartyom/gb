// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.


System.Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] Array = Create(m, n);
Print(Array);
int iMin = 0;
int jMin = 0;
Min(Array, ref iMin, ref jMin);

int[,] NewArr = new int[m - 1, n - 1];

System.Console.WriteLine($"Минимальный элемент {Array[iMin, jMin]} в строке {iMin+1}, столбце {jMin+1}.");

for (int i = 0; i < Array.GetLength(0); i++)
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (i < iMin && j < jMin) NewArr[i, j] = Array[i, j];
        if (i < iMin && j > jMin) NewArr[i, j - 1] = Array[i, j];
        if (i > iMin && j < jMin) NewArr[i - 1, j] = Array[i, j];
        if (i > iMin && j > jMin) NewArr[i - 1, j - 1] = Array[i, j];
    }
Print(NewArr);

void Min(int[,] Array, ref int iMin, ref int jMin)
{
    for (int i = 0; i < Array.GetLength(0); i++)
        for (int j = 0; j < Array.GetLength(1); j++)
            if (Array[i, j] < Array[iMin, jMin]) { iMin = i; jMin = j; }
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


int[,] Create(int x, int y)  // принимает размер массива и возвращает сгенерированный массив случайных трехзначных чисел 
{
    int[,] array = new int[x, y];
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++) array[i, j] = new Random().Next(0, 100);
    return array;
}