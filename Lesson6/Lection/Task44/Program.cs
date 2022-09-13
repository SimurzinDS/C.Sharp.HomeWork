Console.WriteLine("Введите число N");
bool isNumber = int.TryParse(Console.ReadLine(), out int n);

if(isNumber != true)
{
    Console.WriteLine("Это не число");
    return;
}

string Fibonacci(int arg)
{
    int a = 0;
    int b = 1;
    int c = 0;
    string subsequence = String.Empty;
    for (int i = 0; i < arg; i++)
    {
        subsequence = subsequence + Convert.ToString(a) + " ";
        c = a + b;
        a = b;
        b = c;
    }
    return subsequence;
}

string result = Fibonacci(n);
Console.WriteLine(result);