// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих
// и одна с будущего семинара Сгенерировать массив случайных целых чисел размерностью
// m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное.
//Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива,
//причем чтобы каждый элемент гарантированно и только один раз переместился на другое место
//и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре,
//то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [rows, cols];
bool [,] ChangeIndexArray = new bool [rows, cols];
FillArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(-20,21);
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
}

void ChangeRandomArray(int[,] array)
{
    int newI =0;
    

    for (int i=0;i<array.GetLength(0);i++)
        {
            for (int j=0;j<array.GetLength(1);j++)
            if (CheckIsNewPair[i,j]) 
            {
                do
                {
                    newI = new Random().Next(0,array.GetLength(0));
                    newJ = new Random().Next(0,array.GetLength(1));
                }while( newI != newJ && );
            }

        }

}

// Возвращаем true если этот индекс еще не менялся
bool CheckIsNewPair (int i, int j, bool[,] ChangeIndexArray)
{

    return !ChangeIndexArray[i,j];

}