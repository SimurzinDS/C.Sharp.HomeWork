//   Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//   [3 7 22 2 78] -> 76

void FillArray(double[] collection)
{
    double length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = Math.Round((new Random().NextDouble() * 100), 2);
        index++;
    }
}

void PrintArray(double[] col)
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count)
    {
        if (position + 1 != count)
        {
            Console.Write($"{col[position]} ; ");
        }
        else
        {
            Console.Write($"{col[position]}");
        }
        position++;
    }
    Console.Write("]");
}

double[] array = new double[new Random().Next(2, 10)];
FillArray(array);
PrintArray(array);

double GetDifferenceMinMax(double[] arr)
{
    double maxNumber = arr[0];
    double minNumber = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if(maxNumber < arr[i])
        {
           maxNumber = arr[i];
        }

        if(minNumber > arr[i])
        {
           minNumber = arr[i];
        }
    }
    
    double diffMaxMin = maxNumber - minNumber;

    return diffMaxMin;
}

double result = GetDifferenceMinMax(array);
Console.Write($" -> {result}");