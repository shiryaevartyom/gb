// Задача 30: - HARD необязательная Напишите программу, которая на вход получает размерность массива.
// Далее заполняет его случайными уникальными числами и выводит на экран.
// Далее производим сортировку массива от большего к меньшему и выводим на экран.
// Далее придумываем алгоритм перемешивания списка на основе случайности,
// применяем этот алгоритм и выводим на экран результат.
// Встроенные методы работы со списками использовать нельзя.

Console.WriteLine("Какой длинны Уникальный массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());
int depth = 0;

//Проверка - глубина больше ширины - для уникальности массива.
bool checkDepth = false;
while (checkDepth != true)
{
    Console.WriteLine($"Какой глубины будет Уникальный массив (используй число больше чем длина {n}):");
    depth = Convert.ToInt32(Console.ReadLine());
    if (depth > n)
        checkDepth = true;
    else Console.WriteLine("Глубина меньше размера, уникальный массив не создать!");
}

int[] array = CreateRandomUniqueArray(n, depth);

Console.WriteLine($"Сгенерированный уникальный массив, длинна {n} / диапазон генерации {depth}:");
PrintArray(array);

SortArrayMaxToMin(array);

Console.WriteLine($"Отсортированный массив, от большего к меньшему:");
PrintArray(array);

MixingRandomArray(array);

Console.WriteLine($"Перемешанный массив:");
PrintArray(array);

void PrintArray(int[] array) //#### Функция печатает массив  ###################################################################################################
{
    foreach (int el in array) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();

}

int[] CreateRandomUniqueArray(int size, int depth) //#### Функция генерируем Уникальный Массив указанной длины size со случайными цифрами от 0 до depth ################
{
    int[] uniqueArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        bool checkUnique = false;
        int countUnique = 0;
        while (checkUnique != true)
        {
            uniqueArray[i] = new Random().Next(1, depth);
            for (int j = 0; j < i; j++)
            {
                if (uniqueArray[i] != uniqueArray[j]) countUnique++;
            }

            if (countUnique == i) checkUnique = true;
        }
    }
    return uniqueArray;
}

int[] SortArrayMaxToMin(int[] array) //#### Функция сортирует массив от Максимально к Минимальному ###############################################################
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1 ; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }    
    return array;
}

int[] MixingRandomArray(int[] array) //#### Функция Перемешиваем рандомно массив ###############################################################
{

    for (int i = 0; i < array.Length; i++)
    {
        int Position = new Random().Next(0, array.Length);;
        int temporary = array[i];
        array[i] = array[Position];
        array[Position] = temporary;
    }    
    return array;
}