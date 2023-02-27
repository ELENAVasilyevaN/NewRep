// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
 

void MultArray(int[,] Array1, int[,] Array2, int[,] resArray)
{
  for (int i = 0; i < resArray.GetLength(0); i++)
  {
    for (int j = 0; j < resArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < Array1.GetLength(1); k++)
      {
        sum += Array1[i,k] * Array2[k,j];
      }
      resArray[i,j] = sum;
    }
  }
}
int num = InNum("Введите диапазон случайных чисел от 1 до ");
int InNum(string input)
{
  Console.Write(input);
  int output = int.Parse(Console.ReadLine()!);
  return output;
}
 
void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(num);
    }
  }
}
 
void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Количество строк первой матрицы = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов первой матрицы (строк второй матрицы) = ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Количество столбцов второй матрицы = ");
int x = int.Parse(Console.ReadLine()!);
 

int[,] Array1 = new int[m, n];
CreateArray(Array1);
Console.WriteLine($"Вторая матрица:");
WriteArray(Array1);
 
int[,] Array2 = new int[n, x];
CreateArray(Array2);
Console.WriteLine($"Вторая матрица:");
WriteArray(Array2);
 
int[,] resArray = new int[m,x];
 
MultArray(Array1, Array2, resArray);
Console.WriteLine($"Произведение двух матриц есть");
WriteArray(resArray);

