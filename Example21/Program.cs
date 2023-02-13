// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату X1 точки A:  ");
int X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y1 точки A:  ");
int Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z1 точки A:  ");
int Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату X2 точки B:  ");
int X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y2 точки B:  ");
int Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z2 точки B:  ");
int Z2 = int.Parse(Console.ReadLine()!);

double dist = Math.Round(Math.Sqrt(Math.Pow(X1-X2,2) + Math.Pow(Y1-Y2,2) + Math.Pow(Z1-Z2,2)),2);

Console.WriteLine($"Расстояние равно {dist}");
