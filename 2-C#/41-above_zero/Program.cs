// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько целочисленных чисел Вы хотите ввести?:");
int arrayLength = Convert.ToInt32(Console.ReadLine());

int[] array = ReadNumbersInArray(arrayLength);

Console.WriteLine("Вы ввели следущие числа:");
PrintArray(array);

Console.WriteLine($"Вы ввели {CheckAboveZero(array)} чисeл больше нуля.");

void PrintArray(int[] someArray) 
{
    foreach (int el in someArray) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();

}

int[] ReadNumbersInArray(int size) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());

    }
    return array;
}

int CheckAboveZero( int[] CheckedArray )
{
    int count = 0;

    for (int i = 0; i < CheckedArray.Length; i++)
    if ( CheckedArray[i] > 0) count += 1;

    return count;

}