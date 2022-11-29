//Задача необязательная FIZZ BUZZ: Напишите программу, которая выводит на экран числа от 1 до 100.
//При этом вместо чисел, кратных трем, программа должна выводить слово Fizz,
//а вместо чисел, кратных пяти — слово Buzz. Если число кратно пятнадцати,
//то программа должна выводить слово FizzBuzz.
//Задача может показаться очевидной, но нужно получить наиболее простое и красивое решение.

//    for(int i=1; i<100; i++)
//    {
//         if ( i % 3 ==0 && i % 5 ==0) Console.WriteLine("FizzBuzz");
//         else if ( i % 3 ==0) Console.WriteLine("Fizz");
//         else if ( i % 5 ==0) Console.WriteLine("Buzz");
//         else  Console.WriteLine(i);
//    }


   for(int i=1; i<100; i++)
   {
        string output  = "";
        if ( i % 3 ==0 ) output += "Fizz";
        if ( i % 5 ==0 ) output += "Bizz";
        if (output == "") output = Convert.ToString(i);
        Console.WriteLine(output);
   }
   