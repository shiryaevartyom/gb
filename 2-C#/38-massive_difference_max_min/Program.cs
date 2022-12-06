// Задача 38: Задайте массив случайных вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Генерируем массив....");
double[] array = CreateRandomArray(n);

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

Console.WriteLine($"Разность между максимальным {returnValue(array, "max")} и минимальным {returnValue(array,"min")}: {returnValue(array,"max")-returnValue(array,"min")}");


// Печатает массив  #################################################################################

void PrintArray(double[] array) 
{
    foreach (double el in array) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();

}

// Генерируем Массив указанной длины size со случайными вещественными числами ########################

double[] CreateRandomArray(int size) 
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = GetRandomDoubleNumber(0,10);

    }
    return array;
}

// Генерирует случайное вещественное число в диапозоне minimum maximum  ########################

double GetRandomDoubleNumber(double minimum, double maximum)
{ 
    Random random = new Random();
    return random.NextDouble() * (maximum - minimum) + minimum;
}

// Возращает min/max значение в массиве  #####################################################

double returnValue (double[] array, string minmax)
{ 
    double result = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if ( array[i] < result && minmax == "min") result = array[i];
        else if ( array[i] > result && minmax == "max") result = array[i];
    }

    return result;
}