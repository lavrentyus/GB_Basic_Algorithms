Console.Write("Введите номер задачи (2,4,6,8): ");
int unitNumber = Convert.ToInt32(Console.ReadLine());

while (unitNumber!= 2 && unitNumber!= 4 && unitNumber!= 6 && unitNumber!= 8 )
{
    Console.Write("Ошибка выбора задачи. \nВведите номер задачи (2,4,6,8): ");
    unitNumber = Convert.ToInt32(Console.ReadLine());    
}

if (unitNumber == 2)
{
    //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
    //a = 5; b = 7 -> max = 7
    //a = 2 b = 10 -> max = 10
    //a = -9 b = -3 -> max = -3
    Console.WriteLine("Задача 2: ");

    Console.Write("Введите число 'a1': ");
    int a1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число 'a2': ");
    int a2 = Convert.ToInt32(Console.ReadLine());
    int max = a1;
    int min = a1;

    if (a1 > a2) 
    {
        max = a1;
        min = a2;
    } else 
    {
        max = a2;
        min = a1;
    }

    Console.WriteLine("Результат: ");
    Console.WriteLine("a1 = : " + a1 + "; a2 = : " + a2 + "-> max = " + max + "-> min = " + min);
}
else if (unitNumber == 4)
{
    //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    //2, 3, 7 -> 7
    //44 5 78 -> 78
    //22 3 9 -> 22
    Console.WriteLine("Задача 4: ");

    int [] array = {0,0,0};
    int count = 0, max = 0;

    while (count <array.Length) 
    {
        Console.Write("Введите число 'a" + (count + 1) + " ': ");
        array[count] = Convert.ToInt32(Console.ReadLine());
        if (max <  array[count]) max = array[count];
        count++;
    }

    count = 0;
    while (count <array.Length) 
    {
        Console.Write(array[count]);
        count++;
        if (count < array.Length) Console.Write(", ");

    }

    Console.Write(" -> " + max);
}
else if (unitNumber == 6)
{
    //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    //4 -> да
    //-3 -> нет
    //7 -> нет

    Console.WriteLine("Задача 6: ");

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n % 2 == 0) Console.WriteLine(n + " -> Да");
    else Console.WriteLine(n + " -> Нет");
}
else if (unitNumber == 8)
{
    //Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
    //5 -> 2, 4
    //8 -> 2, 4, 6, 8

    Console.WriteLine("Задача 6: ");

    Console.Write("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i <= n; i=i+2)
    {
        Console.WriteLine(i);
    }
}