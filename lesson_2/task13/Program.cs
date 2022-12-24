//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.(можно использовать индексацию строк)
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Задача 13: ");

Console.Write("Введите число : ");
printSimbol(Console.ReadLine(), 2);



void printSimbol(string s, int simbolNamber)
{
    if (s.Length<simbolNamber+1) Console.WriteLine($"{s} -> {simbolNamber+1} цифры нет");
    else Console.WriteLine($"{s} -> {s[simbolNamber]}");
}


