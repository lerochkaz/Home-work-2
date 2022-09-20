// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write("Введите многозначное число (цифры вводить через пробел): ");
string number = Console.ReadLine() ?? "0";
string[] dataList = number.Split(" ");

if (dataList.Length > 2) Console.Write(dataList[2]);
else
{
    Console.WriteLine("Третьей цифры нет");
}
