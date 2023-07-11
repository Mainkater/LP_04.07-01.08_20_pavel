// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1)
{
    Console.WriteLine("Отсутствуют четные числа");
}
if (n <= 0)
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    int counter = 2;
    Console.Write("Четные числа: ");
    while (counter <= n)

    {
        Console.Write(counter + " ");
        counter = counter + 2;
    }
}