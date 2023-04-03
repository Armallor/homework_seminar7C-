// Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли 
// такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также 
// какое число стоит на этом месте или же указание, что такого элемента нет.

int m = vvod("Введите номер строки (человеческой нумерацией, начиная с единицы) ");
int n = vvod("Аналогично номер столбца ");

int[,] array = GetArray(10, 8, 0, 50);

PrintArray(array);

Console.WriteLine();

ElementSearch(array);

// проверка на наличие и нахождение элемента

void ElementSearch(int[,] array)
{
  if (m > array.GetLength(0) || n > array.GetLength(1)) Console.Write("Элемент с входными параметрами в данном массиве отсутствует");
  else Console.WriteLine($"Данный элемент = {array[m - 1, n - 1]}");
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