Console.WriteLine("Введите число и нажмите Enter ");
int evenNumber = Convert.ToInt32(Console.ReadLine());

if (evenNumber % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}