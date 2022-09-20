// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int num = int.Parse(Console.ReadLine() ?? "0");
string[] week = new string[] { "понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресень" };
if ((num == 6) || (num == 7))
{
    Console.WriteLine($"{week[num - 1]}- выходной день");
}
else if (num > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else
{
    Console.WriteLine($"{week[num - 1]}- рабочий день");
}

