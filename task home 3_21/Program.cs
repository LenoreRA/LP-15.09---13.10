// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
{
    double result = Math.Sqrt((Math.Pow((arg4 - arg1), 2) + Math.Pow((arg5 - arg2), 2))+ (Math.Pow((arg6 - arg3), 2)));
    return result;
}

double res = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
Console.WriteLine(res);