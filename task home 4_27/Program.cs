// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    int counter = 0;
    int digit = 0;
    int result = 0;
    while (num > 0)
    {
        digit = num - num % 10;
        result = result + (num - digit);
        num = num / 10;
        counter++;
    }
    return result;
}

int sumNumbers = SumNumbers(Math.Abs(number));
Console.WriteLine($"{sumNumbers}");