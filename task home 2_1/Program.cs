//  Напишите программу, которая принимает на вход трёхзначное число и на 
// выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int showsecondDigit(int num)
{
    int sDigit = num / 10;
    int seDigit = sDigit % 10;
    return seDigit;
}

int seDigit = showsecondDigit(number);
Console.WriteLine($"вторая цифра {number} - {seDigit}");