//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Задача 15: ");


Console.Write("ведите номер дня недели (1-7): ");
int dayNamber = Convert.ToInt32(Console.ReadLine());

while (dayNamber<1 || dayNamber>7)
{
    Console.Write("Ошибка ввода: Введите номер дня недели (1-7): ");
    dayNamber = Convert.ToInt32(Console.ReadLine());
}

if (dayNamber%6==0 || dayNamber%7==0) Console.WriteLine($"{dayNamber} -> выходной");
else Console.WriteLine($"{dayNamber} -> рабочий день");
