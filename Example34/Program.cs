// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

int[] array = GetArray(size, 99, 999);
Console.WriteLine(String.Join(", ", array));

int CountElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 99 && item < 1000 && item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int end = CountElements(array); 
Console.Write($"Количество четных элементов массива равно {end} ");

