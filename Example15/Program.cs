// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели от 1 до 7 num: ");
int num = int.Parse(Console.ReadLine()!);

while (num > 7 || num < 1)
{
Console.WriteLine($"ВВедите цифру от 1 до 7");
num = int.Parse(Console.ReadLine()!);
}

if (num == 6 || num == 7)
{
 Console.WriteLine($"День недели является выходным");   
}
else
{ 
       Console.WriteLine($"День не является выходным");
}

