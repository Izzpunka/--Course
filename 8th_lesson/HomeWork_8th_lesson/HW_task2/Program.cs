// Задача 2: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void SmallestAmountRow(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    int amount = 1000;
    int num;
    int smallest = 0;

    for (int i = 0; i < row_size; i++)
    {   
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
            Console.Write($"{num, 4} ");            

        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
    Console.WriteLine();
    Console.Write($"The row with the lowest amount per position - {smallest + 1}");
}


Console.Write("Enter the number of rows: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] arr_1 = FillArray(row, column, 0, 10);
PrintArray(arr_1);

SmallestAmountRow(arr_1);