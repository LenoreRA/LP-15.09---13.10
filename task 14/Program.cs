// Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

bool IsAliqout(int arg)
{
    return arg % 23 == 0 && arg % 7 == 0;
}

if (IsAliqout(num1)) Console.WriteLine($"да");
else Console.WriteLine($"нет");