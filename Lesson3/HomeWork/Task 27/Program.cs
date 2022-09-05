// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число и нажмите Enter");
bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (!isNumber)
{
    Console.WriteLine("Не является числом");
    return;
}

int GetSumNumber(int arg)
{
    int sum = 0;
    while (arg > 0)
    {
        sum = sum + arg % 10;
        arg = arg / 10;
    }
    return sum;
}

int result = GetSumNumber(number);
Console.WriteLine(result);

