// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

bool firstNumber = int.TryParse(Console.ReadLine(), out int number1);
bool secondNumber = int.TryParse(Console.ReadLine(), out int number2);

if (!firstNumber || !secondNumber)
{
    Console.WriteLine("Одно из чисел не является числом");
}



int GetMathPow(int arg1, int arg2)
{
    int result = 1;
    if (arg2 != 0)
    {
        for (int i = 0; i < arg2; i++)
        {
            result = result * arg1;
        }
    }
    else
    {
        return 1;
    }
    return result;
}

int squareNumber = GetMathPow(number1, number2);
Console.WriteLine(squareNumber);
