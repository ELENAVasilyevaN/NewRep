// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.Clear();

bool CheckTriangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}
Console.Write("Введите число а: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine()!);

if (CheckTriangle(a, b, c))
{
   Console.Write("Треугольник существует"); 
}
else
{
   Console.Write("Треугольник не существует");  
}

