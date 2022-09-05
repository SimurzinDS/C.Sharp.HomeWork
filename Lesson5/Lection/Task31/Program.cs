// Задайте масссив из 12 элементов, заполненный случайными числами из
// промежутка [-9;9]. Найдите сумму отрицательный и положительных
// элементов массива
// Напимер, в массиве [3,9,-8,2,0,-7,2,-1,8,-3,-1,6] сумму положительных
// чисел равна 29, сумма отрицательнвх равна -20.

void FillArray(int[] collection)
{
    Random random = new Random();
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = random.Next(-9, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]} ");
        position++;
    }
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);

int sumPositivNumber = GetSumPositivNumbersInArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма позитивных чисел равна: {sumPositivNumber}");

int sumNegativNumber = GetSumNegativNumbersInArray(array);
Console.WriteLine($"Сумма отрицательных чисел равна: {sumNegativNumber}");

int GetSumPositivNumbersInArray(int[] arr)
{
    int sumPositivNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(array[i] >= 0)
        sumPositivNumber += arr[i];
    }
    return sumPositivNumber;
}

int GetSumNegativNumbersInArray(int[] arr)
{
    int sumNegativNumber = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(array[i] <= 0)
        sumNegativNumber += arr[i];
    }
    return sumNegativNumber;
}
