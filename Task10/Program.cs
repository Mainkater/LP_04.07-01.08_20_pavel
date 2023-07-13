// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 100 || number > 999)
{
    Console.WriteLine("Ошибка ввода");
}

int firstnum = number / 10; // 456 / 10 = 45
int secondnum = firstnum % 10; // 45 % 10 = 5

Console.WriteLine($"Вторая цифра введенного числа -> {secondnum}");
