// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int NechSumEl(int[] array)
{
    int res = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
       res += array[i]; //res +=array[i]
    }
    return res;
}

int[] array = GetArray(size, 99, 999);
Console.WriteLine(String.Join(", ", array));

int res = NechSumEl(array); 
Console.Write($"Сумма элементов, стоящих на нечетных позициях массива равна {res} ");

