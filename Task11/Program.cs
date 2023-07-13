// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное ьехзначное число -> {number}");

// int firstDijit = number / 100;
// int thirdDijit = number % 10;
// int resultDijit = firstDijit * 10 + thirdDijit;
// Console.WriteLine($"Ответ: {resultDijit}");

int result = RemoveSecondDijit(number);
Console.WriteLine($"Ответ: {result}");

int RemoveSecondDijit(int num)

{
    int firstDijit = num / 100;
    int thirdDijit = num % 10;
    int resultDijit = firstDijit * 10 + thirdDijit;
    return resultDijit;
}

