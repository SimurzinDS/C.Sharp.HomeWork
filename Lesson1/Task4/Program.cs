Console.WriteLine("Введите число от N и нажмите Enter");
int N = Convert.ToInt32(Console.ReadLine());
int a = -N;


while (a < N+1)
{
    Console.Write("{0} ", a);
    a++;
}
