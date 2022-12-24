//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Задача 21: ");

double[] point1 = {0,0,0};
double[] point2 = {0,0,0};

void getPointValue(ref double[] point, string pointName)
{
    string s = "";

    Console.WriteLine($"\nТочка {pointName}: ");
    for (int i = 1; i <= 3; i++)
    {
        if (i == 1) s = "X";
        else if (i == 2) s = "Y";
        else s = "Z" ;
        Console.Write($"Введите точку {pointName}({s}): ");
        point[i-1] = Convert.ToDouble(Console.ReadLine());
    }
}

void printDistancePoint(double[] p1,double[] p2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(p2[0]-p1[0], 2)+Math.Pow(p2[1]-p1[1], 2) + Math.Pow(p2[2]-p1[2], 2));
    Console.Write($"A ({p1[0]}; {p1[1]}; {p1[2]}) B ({p2[0]}; {p2[1]}; {p2[2]}) -> {result}");    
}

getPointValue(ref point1, "A");
getPointValue(ref point2, "B");

printDistancePoint(point1, point2);


