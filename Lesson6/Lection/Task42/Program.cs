Console.WriteLine("Введите десятичное число");
bool isNumber = int.TryParse(Console.ReadLine(), out int x);

if(isNumber == false)
{
    Console.WriteLine($"это не десятичное число!");
}

string GetBinareNumber(int arg)
{
    int y = 0;
    string result = String.Empty;
    
    while(arg > 0)
    {
        y = arg % 2;
        result = Convert.ToString(y) + result;
        arg = arg / 2;
    }
    return result;
}

string binareNumber = GetBinareNumber(x);
Console.WriteLine(binareNumber);