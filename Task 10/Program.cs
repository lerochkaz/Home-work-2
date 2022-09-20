// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 100 || number > 999)
{
    Console.WriteLine("Неправильный ввод. Попробуйте ещё раз.");
    return;
}

int first = number / 100;
int second = number % 10;
int result = (number - (first * 100) - second) / 10;
Console.WriteLine(result);

