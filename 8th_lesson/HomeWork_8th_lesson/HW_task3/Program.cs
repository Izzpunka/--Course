// Задача 3: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.


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


int[,] Multiplication(int[,] arr1, int[,] arr2)
{
    int row_size = arr1.GetLength(0);
    int column_size = arr1.GetLength(1);
    int[,] NewMatrix = new int[row_size, column_size];

    if (row_size != arr2.GetLength(0) || column_size != arr2.GetLength(1)) return NewMatrix;
    
    for (int i = 0; i < row_size; i++)       
        for (int j = 0; j < column_size; j++)
            NewMatrix[i, j] = arr1[i, j] * arr2[i, j];            
    return NewMatrix;
}


Console.Write("Enter the number of rows 1: ");
int row_1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 1: ");
int column_1 = int.Parse(Console.ReadLine());

Console.Write("Enter the number of rows 2: ");
int row_2 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns 2: ");
int column_2 = int.Parse(Console.ReadLine());

int[,] arr_1 = FillArray(row_1, column_1, 0, 5);
PrintArray(arr_1);
int[,] arr_2 = FillArray(row_2, column_2, 0, 5);
PrintArray(arr_2);

int[,] NewMatrix = Multiplication(arr_1, arr_2);
PrintArray(NewMatrix);

