// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

double [ , ] GetArray (int m, int n)
{
    double [,] result = new double [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result [i,j] = Convert.ToDouble(new Random().Next(-100,101)/10.0);
        }
    }
    return result;
}

void printArray (double [,] array1)
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


double [,] array1 = GetArray(3,4);
printArray(array1);