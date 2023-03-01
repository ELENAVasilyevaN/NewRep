// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 
Console.Clear();

Console.Write("Задайте натуральное число N ");
int N = int.Parse(Console.ReadLine()!);

int i = 1;
 

int Num(int N, int i)
{
    if (N == i)
        return N;
    else
        Console.Write($"{Num(N, i + 1)}, ");
    return i;
}
 
int IntNum(string result)
{
    Console.Write(result);
    return int.Parse(Console.ReadLine());
}
Console.WriteLine(Num(N, i));
Console.Write($"Натуральные числа промежутка от {N} до 1: ");