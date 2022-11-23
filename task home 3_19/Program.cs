// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isPalindrome(int num)
{
    int n = num;
    int revnum = 0;

    while (n > 0)
    {
        int r = n % 10;
        revnum = revnum * 10 + r;
        n = n / 10;
    }
    return num == revnum;
}

if (isPalindrome(number)) Console.WriteLine($"да, это палиндром");
else Console.WriteLine($"нет, это не палиндром ");

