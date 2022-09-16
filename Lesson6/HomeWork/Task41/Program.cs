// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
string? numbers = Console.ReadLine();

int GetCountPositive(int[] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}



int[] StringToNum(string mas)
{
    int count = 1;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] == ',')
        {
            count++;
        }
    }

    int[] numbers = new int [count];
    int index = 0;

    for (int i = 0; i < mas.Length; i++)
    {
        string temp = "";

        while (mas [i] != ',')
        {
        if(i != mas.Length - 1)
        {
            temp += mas [i].ToString();
            i++;
        }
        else
        {
            temp += mas [i].ToString();
            break;
        }
        }
        numbers[index] = Convert.ToInt32(temp);
        index++;
    }
    return numbers;
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position + 1  != count)
        {
            Console.Write($"{col[position]}, ");
        }
        else
        {
            Console.Write($"{col[position]}");
        }
        position++;
    }
    Console.Write("]");
}

PrintArray(StringToNum(numbers));
int result = GetCountPositive(StringToNum(numbers));
Console.Write($" => {result}");