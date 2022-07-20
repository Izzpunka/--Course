// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

string FindPosition(int[,] arr, int l, int r)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (l > row || l <= 0 || r > column || r <= 0)
        return $"{l} {r} -> It`s not in the array";
    return $"arr[{l}, {r}] = {arr[l - 1, r - 1]} -> It is in the array";
}

Console.Write("Enter the line position: ");
int linePosition = int.Parse(Console.ReadLine());
Console.Write("Enter the column position: ");
int rowPosition = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(3, 5, 1, 100);
Print(arr_1);

Console.WriteLine(FindPosition(arr_1, linePosition, rowPosition));