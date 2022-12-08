// Задача 19 Напишите программу, которая принимает на вход целое число любой разрядности и проверяет,
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет;        12821 -> да;        23432 -> да

    Console.WriteLine("Введите целое число:");
    int n = Convert.ToInt32(Console.ReadLine());

         if ( Palindrom(n) == 0 ) Console.WriteLine($"Число {n}: палиндром");
         else Console.WriteLine($"Число {n}: НЕ палиндром");


//# Функция поиска количества разрядов в числе #################################################

int DigitsInNumber  (int number)
{
return (int)Math.Log10(number)+1;

}

//# Функция проверки числа на палиндром ########################################################

bool Palindrom (int number)
{

int count = 0; // Флаг для хранения не совпадения
         
    for (int i = 1; i < DigitsInNumber(number)/2+1; i++)
        if ( (number/(int)Math.Pow(10,DigitsInNumber(number)-i))%10 != (int)((number%Math.Pow(10,i))/Math.Pow(10,i-1)) ) count++;
    
    if (count > 0) return false; // Не палиндром
    else return true;          // Палиндром

}