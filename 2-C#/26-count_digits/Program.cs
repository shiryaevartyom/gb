// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход
// целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3, 82 -> 2 9,012 ->4

    Console.WriteLine("Введите целое или дробное число положительное число:");
    double n = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Число цифр в числе {n}: {searchDigitsInNumber(convertDoubleToInt(n))}");
    
int convertDoubleToInt (double num) //# Функция двигает запятую в числе double вправо за последнюю цифру
{
    double result = num;
    while ( result-Math.Floor(result) != 0)
    {
        result = result * 10;
    }
    
    return (int)result;
}


int searchDigitsInNumber (int num) //# Функция ищет количество цифр в целом числе ###################
{
    int digit = (int)Math.Log10(num)+1;
    return digit;

}