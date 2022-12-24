//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


Console.Clear();

Console.WriteLine("Задача 19: ");

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number <10000 || number >99999)
{
    Console.Clear();
    Console.Write("Ошибка воода. Введите пятизначное число: ");
    number = Convert.ToInt32(Console.ReadLine());
}

string numberStr = Convert.ToString(number);

bool result = true;;
for (int i = 0; i < numberStr.Length;  i++)
{
    if (numberStr[i] != numberStr[numberStr.Length-1-i])
    {
        result = false;
        break;   
    }
}

Console.WriteLine($"{numberStr} -> {result}");