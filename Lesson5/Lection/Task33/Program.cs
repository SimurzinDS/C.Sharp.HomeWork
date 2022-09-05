Console.WriteLine("Введите искомое число в массиве: ");
int a = Convert.ToInt32(Console.ReadLine());

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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

string FindNumber(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            return "Да";
        }
        index++;
    }
    return "Нет";
}

int [] array = new int[new Random().Next(5, 10)];

FillArray(array);
PrintArray(array);
Console.WriteLine();

string pos = FindNumber(array, a);
Console.WriteLine(pos);

