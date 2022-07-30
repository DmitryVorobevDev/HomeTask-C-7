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

int GetNumber ()
{
    while (true)
    {
        Console.WriteLine ("Введите число для поиска в массиве");
        string valueFromConsole = Console.ReadLine();
        if (int.TryParse(valueFromConsole, out int number)) return number;
        else Console.WriteLine ("Введите корректное число");
    }
}
string FindNumber (int number,int [,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            if (array1[i,j] == number) return ($"Массив содержит число {number}. Его индекс:" + i + "," + j);
        }
    }
    return ($"Массив не содержит число {number}.");
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


int [,] array1 = GetArray(3,6);
int numb = GetNumber();
Console.WriteLine(FindNumber(numb, array1));
printArray(array1);

