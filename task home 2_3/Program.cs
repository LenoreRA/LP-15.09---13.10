// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите цифру дня недели: ");
// int dayNumber = Convert.ToInt32(Console.ReadLine());

// void DayCheck(int dayNumber)
// {
//     if (dayNumber == 6 || dayNumber == 7) Console.WriteLine($"это выходной");
//     else if (dayNumber => 1 && dayNumber <= 5) Console.WriteLine($"это будний день");
//     else (dayNumber)

// }
// DayCheck(dayNumber);

Console.Write("Введите цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 1) Console.WriteLine("нет");
else if (dayNumber == 2) Console.WriteLine("нет");
else if (dayNumber == 3) Console.WriteLine("нет");
else if (dayNumber == 4) Console.WriteLine("нет");
else if (dayNumber == 5) Console.WriteLine("нет");
else if (dayNumber == 6 && dayNumber == 7) Console.WriteLine("да");
else if (dayNumber < 1 || dayNumber > 7) Console.WriteLine("это не день недели");