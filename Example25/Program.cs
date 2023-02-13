// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Deg(int Osn, int Step)

{
    int i = 1;
    int res = i;
    for (i = 1; i <= Step; i++)
    {
        res = res * Osn;
    }
    return res;
}

Console.Write("Введите число A: ");
int Osn = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень B: ");
int Step = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {Osn} в степени {Step} равно {Deg(Osn, Step)}");

