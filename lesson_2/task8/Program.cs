//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Задача 10: ");

Console.Write("Введите число : ");
string a1 = Console.ReadLine();

if (a1.Length<2) Console.WriteLine($"{a1} -> нет данных");
else Console.WriteLine($"{a1} -> {a1[1]}");