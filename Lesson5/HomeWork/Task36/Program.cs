// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-99, 100);
        index++;
    }
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

int [] array = new int[new Random().Next(4, 10)];
FillArray(array);
PrintArray(array);

int GetSumOddNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
          sum += arr[i];
        }
    }
    return sum;
}

int result = GetSumOddNumbers(array);
Console.Write($" -> {result}");