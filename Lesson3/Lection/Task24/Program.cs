bool isNumber = int.TryParse(Console.ReadLine(), out int number);

if (!isNumber)
{
    Console.WriteLine("Is not number");
    return;
}

int GetSumNumber( int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    return sum;
}

int result = GetSumNumber(number);
Console.WriteLine(result);