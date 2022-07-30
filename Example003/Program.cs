// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [ , ] GetArray (int m, int n)
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = new Random().Next(0, 21);
        }
    }
    return result;
}

string GetAverage (int columns, int  [ , ] array1)
{
    double result = 0;
    for (int j = 0; j < array1.GetLength(0); j++)
    {
        result = result + array1 [j, columns-1];
    }
    return ($"Среднее арифметическое стобца {columns} равно {result/array1.GetLength(0)}");
}

void printArray (int [,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i,j]} | ");
        }
    Console.WriteLine();
    }
}

int columns = 4;
int lines = 3;
int [,] array1 = GetArray(lines, columns);
for (int temp = 0; temp < columns; columns--) Console.WriteLine(GetAverage(columns, array1));
printArray(array1);

