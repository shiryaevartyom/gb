// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке. [1,0,1,1,0,1,0,0] 
// обернуть в функцию булеввого типа, выводим массив через запятую
// Написать функцию которая определяет больше ли 1 чем 0 в массиве

Console.WriteLine("Какой длинны массив будем генерировать:");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomBoolArray (n);

PrintArray(array);

if (CheckOne(array)) Console.WriteLine("В Массиве единиц больше чем нулей");
else Console.WriteLine("В Массиве нулей больше чем единиц");


void PrintArray (int[] a) //#### Функция печатаем массив  ########################################################
{
    for (int i=0; i<a.Length; i++) Console.Write($"{a[i]}, ");
    Console.WriteLine($"{a[^1]}");
}


bool CheckOne(int[] a)  //#### Функция проверяем кол-во единиц  ################################################
{
    int sum = 0;
    for (int i=0; i < a.Length; i++) sum = sum + a[i];
    
    if (sum > a.Length/2) return true;
    else return false;
}

int[] CreateRandomBoolArray (int count) //#### Функция генерируем Массив указанной длины с 1 и 0 ################
{
    int[] array = new int[count];
    for (int i=0; i<count; i++) array[i] = new Random().Next(0, 2);
    return array;    
}