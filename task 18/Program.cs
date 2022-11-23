// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите четверть:");
int quarter = Convert.ToInt32(Console.ReadLine()); // конвертируем в число номер четверти
string range = Quarter(quarter); // создаем переменную типа string и записываем результат метода 
Console.WriteLine(range);

string Quarter (int quart) // здесь указывается тип возвращаемого значения!
{
    if (quart == 1) return "x > 0, y > 0";
    if (quart == 2) return "x < 0, y > 0";
    if (quart == 3) return "x < 0, y < 0";
    if (quart == 4) return "x > 0, y < 0";
    return "Введены некорректные данные";
}

