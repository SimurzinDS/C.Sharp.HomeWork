void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(-10, 10);
        index++;
    }
}

void PrintArray( int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int [] SingReplacement(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    int a = -1;
    while (index < count)
    {
        arr[index] = arr[index] * a;
        index++;
    }
    return arr;
}

int [] array = new int[new Random().Next(0, 10)];

FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(SingReplacement(array));
