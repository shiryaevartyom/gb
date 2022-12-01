//Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Сколько N-мерное пространство:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты A точки (по одномай на строку):");
int[] array_a = EnterCoord (n);

Console.WriteLine("Введите координаты B точки (по одномай на строку):");
int[] array_b = EnterCoord (n);

int sum = 0;

    for(int i=0; i<n; i++)
    {
        int squaring = 0;
        squaring = ( (array_a[i] - array_b[i])*(array_a[i] - array_b[i]) );
        sum = sum + squaring;
    }

double dist = Math.Sqrt(sum); 

Console.WriteLine($"Расстояние между точками A и B {dist}");

int[] EnterCoord (int count) //#### Функция Заносим координаты точек ################
{
    int[] array = new int[count];
    for (int i=0; i<n; i++) array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}