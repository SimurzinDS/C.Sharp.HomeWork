// Задача 28:
// Напишите программу, которая принимает на вход значение 
// число N и выдает произведение чисел от 1 до N

bool isNumber = int.TryParse(Console.ReadLine(), out int number);

int GetFactorial(int arg)
{
    int result = 1;
    if(arg > 0)
    {
        for (int i = 1; i <= number; i++)
        {
            result = result * i;
        }
        return result;
    }
    else
    {
        for (int i = -1; i >= number; i--)
        {
            result = result * i;
        }
        return result;
    }
}

int Sum = GetFactorial(number);
Console.WriteLine(Sum);