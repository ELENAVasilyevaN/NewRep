// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();

int[] GetArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(array.Length);
    }
    return array;
}

void PrintArray(int[] NewArray)
{
    Console.Write("[");
    for (int i = 0; i < NewArray.Length - 1; i++)
    {
        Console.Write($"{NewArray[i]}, "!);
    }
    Console.Write($"{NewArray[NewArray.Length - 1]}");
    Console.Write("]");
}
int[] array = GetArray();

PrintArray(array);

