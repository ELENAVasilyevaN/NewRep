// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8  -> 30

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
 
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
 
SumMN(M, N);
 
void SumMN(int M, int N)
{
    Console.Write($" M = {M}; N ={N} -> {newSumMN(M - 1, N)}");
}
 
int newSumMN(int M, int N)
{
    int result = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        result = M + newSumMN(M, N);
        return result;
    }
}

