// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
//452 -> 11;    82 -> 10;   9012 -> 12

Console.WriteLine("Введите целое положительное число:");
    int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Сумма цифр разрядов в введеном числе {n}: {sumDigits (n)}");


int countDigits (int num) //#### Функция возвращает количество разрядов в числе num ################################
{
   int digit = (int)Math.Log10(num)+1;
   return digit;
}

int getDigits (int n, int num) //#### Функция возвращает цифру в разряде n, числа num #####################################
{
   int digit = (int)(num/Math.Pow(10,n-1)%10);
   return digit;
}

int sumDigits (int num) //#### Функция возвращает цифру в разряде n, числа num #####################################
{
   int sum = 0;
   for (int i=1; i < (countDigits(num)+1); i++) sum = sum + getDigits(i, num);
   return sum;
}