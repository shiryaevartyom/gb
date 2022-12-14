// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Программа ищет координаты точки пересечения кривых");
Console.WriteLine("y = k1 * x + b1; y = k2 * x + b2");

Console.Write("Введите коэфициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэфициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэфициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите коэфициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Точка пересечения x,y: ");
PrintArray(CalculatePoin(b1, b2, k1, k2));


double[] CalculatePoin (double b1, double b2, double k1, double k2)
{

    double[] array = new double[2];
    
//    y = k1 * x + b1, y = k2 * x + b2
//    k1 * x + b1 = k2 * x + b2
//    k1 * x - k2 * x = b2 - b1
//    x (k1 - k2) = b2 - b1
//    x = (b2 - b1) / (k1 - k2)

    array[0] = (b2-b1)/(k1-k2);
    array[1] = k1 * array[0] + b1;
    

    return array;

}

void PrintArray(double[] someArray) 
{
    foreach (double el in someArray) // этот цикл только для просмотра и тут нет индексов
        Console.Write($"{el} ");
    Console.WriteLine();
}