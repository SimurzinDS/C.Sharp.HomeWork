Console.WriteLine("Введите 3 числа через Enter");
bool isNumber1 = int.TryParse(Console.ReadLine(), out int a);
bool isNumber2 = int.TryParse(Console.ReadLine(), out int b);
bool isNumber3 = int.TryParse(Console.ReadLine(), out int c);

if(isNumber1 != true || isNumber2 != true || isNumber3 != true)
{
    Console.WriteLine("Одно из введенных параметров не число!");
}

bool GetToBeOrNotToBe(int x, int y, int z)
{
    if(x <= 0 || y <= 0 || z <= 0)
    {
        return false;
    }
    if(x < y+z && y < x + z && z < x + y)
    {
        return true;
    }
    else return false;
}

bool result = GetToBeOrNotToBe(a, b, c);
Console.WriteLine(result);