// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите ряд чисел, разделенных запятой и пробелом. Пример: 1, 2, и тд. : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string DelSpaces (string number)
{
  string space = string.Empty;
  for (int i = 0; i < number.Length; i++)
  {
    if (number[i] != ' ') 
    {
      space += number[i];
    }
  }
  return space;
}

void СheckNumber2 (int  number)
{
      if (number == '0'||number == '1'||number == '2'||number== '3'||number == '4'||number== '5'||number == '6'||number == '7'||number == '8'||number == '9'||number == ','||number == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода.");

      }
}

int[] ArrayOfNumbers(string seriesNew)
{
    int[] arrayOfNumbers = new int[1];

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = String.Empty;

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();
        }
        j++;
    }
    return arrayOfNumbers;
}


void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count)
  {
    Console.Write(coll[index]);
    index++;
    if (index < count)
    {
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = DelSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);