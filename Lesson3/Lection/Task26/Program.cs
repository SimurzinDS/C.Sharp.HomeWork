// Напишите программу, которая, принимает на вход число и 
// выдает количество цифр в числе.

// Вариант 1

bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(!isNumber)
{
    Console.WriteLine("Введите число");
    return;
}

int GetDigitsNumber(int arg)
{
    int count = 0;
    // int count2 = 0;
    if(arg == 0)
    {
        return 1;
    }
    while( arg != 0)
    {
        count++;
        arg = arg / 10;
    }
    return count;
}

int digitsNumber = GetDigitsNumber(number);
Console.WriteLine(digitsNumber);
