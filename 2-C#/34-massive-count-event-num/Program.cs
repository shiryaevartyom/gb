// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Генерируем массив....");
int[] array = CreateRandomThreeDigitArray(n);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

Console.WriteLine($"Четных чисел в сгенерированном массиве: {CalculateEvenNumbersInMassive(array)}");


// Печатает массив  #################################################################################

void PrintArray(int[] array) 
{
    foreach (int el in array) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();

}

// Генерируем Массив указанной длины size со случайными трехзначными цифрами ########################

int[] CreateRandomThreeDigitArray(int size) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99, 999);

    }
    return array;
}

// Подсчитываем кол-во четных чисел в массиве ####################################################

int CalculateEvenNumbersInMassive(int[] array) 
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}