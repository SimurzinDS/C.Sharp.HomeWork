// Задача 34: Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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

int GetEvenNumbers(int []arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int [] array = new int[new Random().Next(1, 10)];

FillArray(array);
PrintArray(array);
int result = GetEvenNumbers(array);
Console.Write($" => {result}");