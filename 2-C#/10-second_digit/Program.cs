// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5;     782 -> 8;   918 -> 1

try // Пытаемся выполнить ВЕСЬ программный код
    // Сюда засовываем всю основную программу, ну кроме функций разумеется.
{
    Console.WriteLine("Введите целое положительное ТРЕХ значное число:");
    int n = Convert.ToInt32(Console.ReadLine());

    // Проверяем умеет ли наш добрый пользователь считать до трех
    if (n < 100 || n > 999) Console.WriteLine($"Пересчитайте сколько цифр в числе {n}, выпейте кофе и возвращайтесь!");
    else     Console.WriteLine($"Вторая цифра в введеном числе {n}: {(int)(n%Math.Pow(10,2)/10)}");

}
catch // если же не получилось выполнить всю программу, то уходим в этот блок и информуруем пользователя
{
    Console.WriteLine("Ошибка: Надо было вводить именно целое число цифрами!");
}