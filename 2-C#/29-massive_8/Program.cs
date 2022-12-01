// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArrayKeyboard (n);

Console.WriteLine("Посмотрите на массив:");
PrintArray (array);

int[] CreateArrayKeyboard (int count) //#### Функция генерируем Массив указанной длины с 1 и 0 ################
{
    int[] array = new int[count];
    for (int i=0; i<count; i++) 
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;    
}

void PrintArray (int[] a) //#### Функция печатаем массив  ########################################################
{
    for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}