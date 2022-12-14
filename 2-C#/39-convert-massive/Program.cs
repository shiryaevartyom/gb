// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


int[] CreateArray(int size)  // принимает размер массива и возвращает сгенерированный массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-9, 10);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el,2}\t");
    Console.WriteLine();
}

void Reverse(int[] array)
{
    int size = array.Length;
    int temp;
    for (int i = 0; i < size/2; i++)
        // (x,y) = (y,x)
        {
            temp = array[i];
            array[i] = array[size-1-i];
            array[size-1-i] = temp;
        }
        //(array[i] , array[size-1-i]) = (array[size-1-i] , array[i]);
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
PrintArray(array);
Reverse(array);
PrintArray(array);