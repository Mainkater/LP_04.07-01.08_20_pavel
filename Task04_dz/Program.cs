﻿// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

// int m = 2;

// if (a > b && a > c)
// {
//     Console.Write($"Максимальное число {a}");
// }
// if (b > a && b > c)
// {
//     Console.Write($"Максимальное число {b}");
// }
// if (c > a && c > b)
// {
//     Console.Write($"Максимальное число {c}");
// }

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число: {max}");