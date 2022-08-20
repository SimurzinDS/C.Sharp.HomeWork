Console.WriteLine("Введите число и нажмите Enter ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число и нажмите Enter ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;

if (c == a)
{
    Console.WriteLine("Число {0} являеться квадратом числа {1}", a, b);
}
else
{
    Console.WriteLine("Число {0} не являеться квадратом числа {1}", a, b);
}