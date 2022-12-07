// Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел от 1 до А.
// от 1 до А.
// 7 -> 28 // 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // еще раз! int - задаем целочисленный ряд и конвертируем его. это 1й пункт задачи
int sumResult = SumNumbers(number); // вызываем метод
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumResult}");

int SumNumbers(int num)
{
    int sum = default; // default ставиться потому что нужное значение еще не определено
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}


// int SumNumbersVer2(int num)
// {
//     int sum = default;
//     int counter = 1;
//     while (counter <= num)
//     {
//         sum = sum + counter;
//         counter++;
//     }
//     return sum;
// }