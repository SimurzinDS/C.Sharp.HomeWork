Console.WriteLine("Введите число и нажмите Enter ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число и нажмите Enter ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Число {0} больше числа {1}", a, b);
}
else
{
    Console.WriteLine("Число {1} больше числа {0}", a, b);
}