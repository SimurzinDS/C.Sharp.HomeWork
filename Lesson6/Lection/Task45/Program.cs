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

int [] array = new int[new Random().Next(1, 10)];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int[] GetCopyArr (int[] arr)
{
    int [] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arr2[i] = arr[i];
    }
    return arr2;
}

int[] arrCopy = GetCopyArr(array);
PrintArray(arrCopy);