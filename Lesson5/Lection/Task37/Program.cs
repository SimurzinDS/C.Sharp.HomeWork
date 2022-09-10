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

int GetSizeArray (int [] arr3)
{
    int a = 0;
    if(arr3.Length % 2 == 0)
    {
        a = arr3.Length / 2;
    }
    else
    {
        a = arr3.Length / 2 + 1;
    }
    return a;
}

int[] GetMultiplicationArray(int[] arr, int arg)
{
    int[] arr2 = new int[arg];
    int count = arr.Length;

    for (int i = 0; i < arg; i++)
    {
        arr2[i] = arr[i];
        if (i < count / 2)
        {
            arr2[i] *= arr[count - 1 - i];
        }
    }
    return arr2;
}

int [] array = new int[new Random().Next(3, 10)];

FillArray(array);
PrintArray(array);
Console.WriteLine();

var size = GetSizeArray(array);
var result = GetMultiplicationArray(array, size);
PrintArray(result);