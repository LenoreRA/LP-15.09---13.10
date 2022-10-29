// Напишите программу, которая на вход принимает два
// числа и проверяет, является ли первое число квадратом
// второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите первое число: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
int square = numb2 * numb2;
if (numb1 == square)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}