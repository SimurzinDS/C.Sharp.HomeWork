void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 124);
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

int FindNumber(int[] collection)
{
    int count = collection.Length;
    int index = 0;
    int count2 = 0;

    while(index < count)
    {
        if (collection[index] > 9 && collection[index] < 100)
        {
            count2++;
        }
        index++;
    }
    return count2;
}

int [] array = new int[5];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = FindNumber(array);
Console.WriteLine(pos);
