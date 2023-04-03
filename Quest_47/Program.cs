// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

int rows = vvod("Введите количество строк: ");

int columns = vvod("Введите количество столбцов: ");

double[,] array = GetArray(rows,columns, 0, 99);
PrintArray(array);

// ----------------Заполнение массива
double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] res = new double[m,n];

    for (int i = 0; i < m; i++)
    {
      for(int j = 0; j < n; j++)
      {
        res[i, j] = new Random().Next(minValue, maxValue);
        res[i, j] += Math.Round(new Random().NextDouble(), 2);
      }
    }
    return res;
}

// -----------------Вывод массива-----------------
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int vvod (string text)
{
  Console.Write(text);
  return Convert.ToInt32(Console.ReadLine()!);
}