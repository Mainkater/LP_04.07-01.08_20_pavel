// Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());
// if(number < 0) number =- number;


int count = GetCountDijit(number);
Console.WriteLine($"Колличество цифр в числе {number} = {count}");

int GetCountDijit(int num)
{
    if(num == 0) return 1;

    int counter = 0;
    while(num != 0)
    {
        num = num / 10; // num /= 10; отсекаем цифры
        counter++;
    }
    return counter;
}