// Задача 57: Составить частотный словарь элементов двумерного массива.  
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных. 
Console.WriteLine("Введите количество строк двумерного массива"); 
int rows = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов двумерного массива"); 
int cols = Convert.ToInt32(Console.ReadLine()); 
int[,] array = new int[rows, cols]; 
FillArray(array); 
PrintArray(array); 
Console.WriteLine(); 
CountElement(array); 
 
void CountElement(int[,] a) 
{ 
    MinMaxArray(array, out int min, out int max); 
    for (int k = min; k <= max; k++) 
    { 
        int count = 0; 
        for (int i = 0; i < array.GetLength(0); i++) 
            for (int j = 0; j < array.GetLength(1); j++) 
                if (a[i, j] == k) 
                    count = count + 1; 
        if (count !=0) 
        Console.WriteLine($"Число {k} содержится в массиве {count} раз."); 
    } 
} 
void MinMaxArray(int[,] m, out int min, out int max) 
{ 
    min = m[0, 0]; 
    max = m[0, 0]; 
 
    for (int i = 0; i < m.GetLength(0); i++) 
    { 
        for (int j = 0; j < m.GetLength(1); j++) 
            if (m[i, j] < min) 
            { 
                min = m[i, j]; 
            } 
    } 
    for (int i = 0; i < m.GetLength(0); i++) 
    { 
        for (int j = 0; j < m.GetLength(1); j++) 
            if (m[i, j] > max) 
                max = m[i, j]; 
    } 
    // Console.WriteLine($"Минимальное значение массива {min}."); 
    // Console.WriteLine($"Максимальное значение массива {max}."); 
} 
 
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