// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.  
// Определить , является ли это сторонами треугольника.  
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним. 
 
Console.WriteLine("Введите три числа."); 
double a = Convert.ToInt32(Console.ReadLine()); 
double b = Convert.ToInt32(Console.ReadLine()); 
double c = Convert.ToInt32(Console.ReadLine()); 
if (IsTriangle(a, b, c)) Console.WriteLine("Треугольник существует!"); 
else Console.WriteLine("Треугольник не существует!"); 
 
if (IsTriangle(a, b, c)) TriangleValues(a, b, c); 
 
 
bool IsTriangle(double a, double b, double c) 
{ 
    if ((a < b + c) && (b < a + c) && (c < a + b)) return true; 
    else return false; 
} 
 
void TriangleValues(double a, double b, double c) 
{ 
    double alfa; // углы 
    double beta; 
    double gamma; 
 
    alfa = Math.Acos((c * c + b * b - a * a) / (2 * b * c)) * 180 / Math.PI; 
 
    beta = Math.Acos((c * c + a * a - b * b) / (2 *a * c)) * 180 / Math.PI; 
    gamma = 180 - alfa - beta; 
    Console.WriteLine($"Углы равны {alfa}; {beta}; {gamma}"); 
 
    double S = 0; 
    S = b * c / 2 * Math.Sin(alfa*Math.PI/180); 
    Console.WriteLine($"S = {S}"); 
 
    double P = 0; 
    P = a + b + c; 
    Console.WriteLine($"P = {P}"); 
 
    if (alfa == 90 || beta == 90 || gamma == 90) Console.WriteLine("Треугольник прямоугольный"); 
 
    if (a == b && b == c) Console.WriteLine("Треугольник равносторонний"); 
    else if (a == b || b == c ||  a == c) Console.WriteLine("Треугольник равнобедренный"); 
}