﻿// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine($"Третья цифра - {numberText[2]}");
}
else
{
    Console.WriteLine($"Третей цифры нет");
}

// int ThirdDigit(int num)
// {
//     while (number > ) num / 10;
//     int thirdDigit = num % 10;
//     return thirdDigit;
// }
// int thirdDigit = ThirdDigit(number);
// Console.WriteLine($"третья цифра = {thirdDigit}");