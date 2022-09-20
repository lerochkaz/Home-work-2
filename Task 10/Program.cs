// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();
int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int first = number / 100;
int second = number % 10;
int result = (number - (first * 100) - second) / 10;
Console.WriteLine(result);

