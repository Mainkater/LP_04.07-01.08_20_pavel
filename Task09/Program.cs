// Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = new Random().Next(10, 100); //99 + 1 = 100
Console.WriteLine($"Случайное положиельное двухзначное число из диапозона 10 - 99 -> {number}");

// int firstDijit = number / 10; // 78 / 10 = 7
// int secondDijit = number % 10; // 78 = 70 + 8

// if (firstDijit > secondDijit)
//     Console.WriteLine($"Максимальная цифра чсла -> {firstDijit}");
// else
// {
//     Console.WriteLine($"Максимальная цифра чсла -> {secondDijit}");
// }

int maxDijit = MaxDijit(number);
Console.WriteLine($"Максимальная цифра чсла -> {maxDijit}");

int MaxDijit(int num)
{
    int firstDijit = num / 10;
    int secondDijit = num % 10;
    // if (firstDijit > secondDijit) return firstDijit;
    // return secondDijit;
    return firstDijit > secondDijit ? firstDijit : secondDijit;
}