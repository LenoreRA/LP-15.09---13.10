// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
int result = DigitalMultiplication(number);
Console.WriteLine($"произведение чисел от 1 до {number} = {result}");
}
else Console.WriteLine("Введено некорректное значение");

// int DigitalMultiplication(int num)
// {
//     int multiplicator = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         multiplicator = multiplicator * i;
//     }
//     return multiplicator;
// }

int DigitalMultiplication(int num)
{
    int counter = 1;
    int res = 1;
    while (counter <= num)
    {
        res = res * counter;
        counter++;
    }
    return res;
}

