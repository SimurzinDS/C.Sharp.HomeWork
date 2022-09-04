// Напишите программу, которая, принимает на вход число и 
// выдает количество цифр в числе.

// Вариант 1

bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if(isNumber != true)
{
    Console.WriteLine("Введите число");
    return;
}

int GetDigitsNumber(int arg)
{
    string str = Convert.ToString(arg);
    int result = str.Length;
    return result;
}

int digitsNumber = GetDigitsNumber(number);
Console.WriteLine(digitsNumber);
