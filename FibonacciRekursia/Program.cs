// // 1. Определить число, факториал которого надо вычислить

// int Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6



// // 2. Определить число, факториал большого числа которого надо вычислить

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine(Factorial(i)); //вывод каждого действия в отдельной строке
// }


// // 3. Определить число, факториал большого числа которого надо вычислить. Задача 2, вывод развернутый

// int Factorial(int n)
// {
//     // 1! = 1
//     // 0! = 1
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}"); 
// }


// // 4. факториал числа. int меняем на double
// double Factorial(int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
//  Console.WriteLine($"{i}! = {Factorial(i)}");
// }


// 5. Фибоначчи. Сложение двух предшествующих чисел

// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// //6. Фибоначчи. Как будут считаться некоторые числа Фибоначчи. Покажем первые 10. 

// int Fibonacci(int n)
// {
//     if (n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 1; i < 10; i++)
// {
//     Console.WriteLine(Fibonacci(i));
// }



// // 7. Фибоначчи Фибоначчи так,
// //чтобы возвращалось double-значение. 

// double Fibonacci(int n)
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < 50; i++)
// {
//  Console.WriteLine(Fibonacci(i));


// 8. то же, что и задача 7, только вывод с расширенным ответом

double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 46; i++)
{
 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}



