// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Генерируем массив....");
int[] array = CreateRandomArray(n);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

Console.WriteLine($"Сумма чисел на нечетных позициях: {SumNumOnOddPos(array)}");


// Печатает массив  #################################################################################

void PrintArray(int[] array) 
{
    foreach (int el in array) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();

}

// Генерируем Массив указанной длины size со случайными трехзначными цифрами ########################

int[] CreateRandomArray(int size) 
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-999, 999);

    }
    return array;
}

// Подсчитываем кол-во четных чисел в массиве ####################################################

int SumNumOnOddPos(int[] array) 
{
    int sum = 0;

    for (int i = 1; i < array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}