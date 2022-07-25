// Задача 1: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillArray(int rows, int columns, int from, int to)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(from, to);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($" {array[i, j],2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortRowElements(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            if (array[i, j] < array[i, k])
            {
                (array[i, j], array[i, k]) = (array[i, k], array[i, j]);
            }
        }
    }
    return array;
}

int[,] array = FillArray(3, 4, 1, 10);
PrintArray(array);

int[,] sortedArray = SortRowElements(array);
PrintArray(sortedArray);