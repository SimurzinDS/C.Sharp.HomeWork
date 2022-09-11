void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
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

int [] array = new int[new Random().Next(2, 10)];
FillArray(array);
PrintArray(array);

Console.WriteLine();

int [] GetReverseArray(int[] arr)
{
    int tmp = 0;
    for (int i = 0; i < arr.Length/2; i++)
    {
        tmp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length-1-i] = tmp;
    }
    return arr;
}

int [] result = GetReverseArray(array);
PrintArray(result);