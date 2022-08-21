Console.WriteLine("Введите число A и нажмите Enter ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B и нажмите Enter ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C и нажмите Enter ");
int C = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (A > B)
{
    if (A > C)
    {
        max = A;
    }
    else 
    {
        max = C;
    }
}
else
{
    if (B > C)
    {
        max = B;
    }
    else
    {
        max = C;
    }
}
Console.WriteLine("Max = {0} ", max);