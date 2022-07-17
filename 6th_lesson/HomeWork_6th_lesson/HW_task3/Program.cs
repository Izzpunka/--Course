// Напишите программу, которая будет создавать копию заданного двумерного массива с помощью поэлементного копирования.

void PrintArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    {
        for (int i = 0; i < row_size; i++)
        {
            for (int j = 0; j < column_size; j++)
            {
                Console.Write($"{arr[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

    void FillArray(int row, int column, int from, int to)
    {
        int[,] arr = new int[row, column];

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                arr[i, j] = new Random().Next(from, to);
            }
            return arr;
        }
    }

    int CopyMass(int [,] new_arr)
    {
        int[,] new_arr = new int[row_size, column_size];
        int row_size = new_arr.GetLength(0);
        int column_size = new_arr.GetLength(1);
        

        for (int i = 0; i < row_size; i++)
        {
            for (int j = 0; j < column_size; j++)
            {
                new_arr[i, j] = new Random().Next(from, to);
            }
            return new_arr;
        }
    }


    int[,] arr_1 = FillArray(2, 5, 1, 11);
    Print(arr_1);
    int[,] new_arr = CopyMass(arr_1);
    Print(new_arr);
