// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int rows = vvod("Введите количество строк: ");

int columns = vvod("Введите количество столбцов: ");

int[,] tableOfValues = GetArray(rows, columns, 0, 99);

PrintArray(tableOfValues);

Console.WriteLine();

double[] secondaryArithmetic = ArithmeticMean(tableOfValues);

Console.WriteLine($"[{String.Join(",", secondaryArithmetic)}]");

// Метод нахождения среднего арифметического каждого столбца и записи в массив

double[] ArithmeticMean (int[,] array)
{
  double[] massiv = new Double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
      {
        for (int i = 0; i < array.GetLength(0); i++)
        {
          massiv[j] += array[i, j];
        }
        massiv[j] = Math.Round((massiv[j] / array.GetLength(0)), 2);
      }
  return massiv;
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int vvod (string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}

