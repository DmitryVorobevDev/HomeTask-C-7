//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

string checkResult (int position1, int position2, int [ , ] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (i == position1 && j == position2) return ($"Число с заданным индексом {array1[i,j]}");
        }
    }
    return "Числа с заданым индексом нет в массиве";
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

int [,] array1 = GetArray(6,6);
Console.WriteLine("Введите первое значение индекса");
int position1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе значение индекса");
int position2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(checkResult(position1, position2, array1));
printArray(array1);

