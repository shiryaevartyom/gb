// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3 [6 7 3 6] -> 36 21


Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray (n);

PrintArray(array);

PrintArray(multArray(array));


int[] multArray(int[] array)
{
    int k = array.Length - 1;
    int[] multArray = new int[array.Length/2+array.Length%2];
    for (int i=0; i <= k; i++) 
    {
        if (k != i) 
        multArray[i]= array[i]*array[k];
        else multArray[i] = array[i];
        k--;
    }
    return multArray;
}


int[] CreateRandomArray (int size) //#### Функция генерируем Массив указанной длины size со случайными цифрами от 0 до depth ################
{
    int[] array = new int[size];
       
    for (int i=0; i<size; i++) array[i] = new Random().Next(1, 10);
     
    return array;    
}


void PrintArray (int[] a) //#### Функция печатает массив  ########################################################
{
    for (int i=0; i<a.Length-1; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}