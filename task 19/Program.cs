// Math.Pow(2, 10);
// double num = Math.Sqrt(10);

// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// Напишите программу, которая
// принимает на вход координаты двух точек
// и находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());

double Distance(int arg1, int arg2, int arg3, int arg4)
{
    double result = Math.Sqrt((Math.Pow((arg3 - arg1), 2) + Math.Pow((arg4 - arg2), 2)));
    return result;
}

double res = Math.Round(Distance(x1, y1, x2, y2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);

