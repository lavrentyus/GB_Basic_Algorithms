//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Задача 23: ");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] result = new double[number];

for (int i = 0; i < number; i++)
{
    result[i] = Math.Pow(i+1,3);
}

Console.WriteLine($"{number} -> [{string.Join(", ", result)}]"); 