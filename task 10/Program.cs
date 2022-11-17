// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int number = new Random().Next(100, 1000);
int RemoveSecondDigit(int num)
{
    int thirdDigit = num % 10;
    int firstDigit = num / 100;
    int newDigit = thirdDigit + firstDigit * 10;
    return newDigit;
}
int newDigit = RemoveSecondDigit(number);
Console.WriteLine($"Итоговое число от {number} = {newDigit}");