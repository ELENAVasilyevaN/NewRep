// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int SumNum(int Num)
{ 
    int res = 0; 
    while (Num > 0) 
    { 
                res = res + Num % 10;
        Num = Num / 10;
    }
return res;
}
Console.Clear();
Console.Write("Введите число N: ");
int Num = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {Num} равна {SumNum(Num)}");

