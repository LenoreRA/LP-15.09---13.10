// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// string numberText = Convert.ToString(number);
// if (numberText.Length > 2)
// {
//     Console.WriteLine($"Третья цифра - {numberText[2]}");
// }
// else
// {
//     Console.WriteLine($"Третей цифры нет");
// }

// int num = 13;
// int count = 0;
// int[] arr = new int[num / 2];
// while (count <= num)
// {
//     if (count % 2 == 0)
//         // Console.Write($"{count}");
//         arr[count] = count + 2;

//     count++;
// }

Console.WriteLine("Введите цифру:");
int evenNums = Convert.ToInt32(Console.ReadLine());

int[] EvenNums(int num)
{
    int count = 0;
    int[] arr = new int[num / 2];
    while (count <= num)
    {
        if (count % 2 == 0)
            // Console.Write($"{count}");
            arr[count] = count + 2;

        count++;
    }
    return arr;
}
Console.WriteLine($"{EvenNums}");

// void EvenNums(int num)
// {
//     int count = 2;
//     while (count <= num)
//     {
//         if (count % 2 == 0)
//             Console.Write($"{count}");
//     }

//         count += 2;
// }    
