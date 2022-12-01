


Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray (n);


int[] CreateRandomArray (int count) //#### Функция генерируем Массив указанной длины c 1 100 ################
{
    int[] array = new int[count];
    for (int i=0; i<count; i++) array[i] = new Random().Next(0, 101);
    return array;    
}

// Найдем  минимальное запишем в переменную
int[] SearchMin(int[] a)
{
    int minIndex1 = 0;
    int minIndex2 = 0;

    for (int i=0; i<array.Length; i++)
    {
        if (array[i] = array[minI])
        if (array[i] < array[minIndex]) minIndex = i;

    }

        return 
}
// В Массиве ищем вхождения числа самое левое и самое правое