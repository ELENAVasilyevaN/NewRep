// Ъадача 32. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.

// Console.Clear();
// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return result;
// } 

// void SigChange(int[] array) //название нью Арей даем сами
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1; //array[i]=-array[i]
//     }
// }

// int[] array = GetArray(-12, -9, 9);
// Console.WriteLine(String.Join(", ", array)); 
// SigChange(array); 
// Console.WriteLine(String.Join(", ", array));

Console.Clear();
int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}
void SigChange(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
}
int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));
SigChange(array);
Console.WriteLine(String.Join(", ", array));
