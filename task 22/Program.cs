// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void SquareTable(int number)
{
    int counter = 1;
    while (counter <= number)
    {
        Console.WriteLine($"| {counter, 3} | {counter * counter, 4} |");
        counter++;
    }
}
if (num >0) SquareTable(num);
else Console.WriteLine("Введено некорректное значение");



// Math.Pow(2, 10);
// double num = Math.Sqrt(10);
// double res = Math.Round(num, 2, MidpointRounding.ToZero);
// System.Console.WriteLine(res);

// System.Console.WriteLine($"{n} = {n * n}");

